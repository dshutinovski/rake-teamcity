require 'albacore'

OUTPUT_DIRECTORY = 'output'
SOLUTION_FILE = 'src/Project.sln'
PACKAGE_FILE = 'app.zip'

task :clean do 
  FileUtils.rm_rf(OUTPUT_DIRECTORY)
  FileUtils.mkdir(OUTPUT_DIRECTORY)
end

msbuild :build do |msb|
  sh 'nuget restore src/'
  msb.properties :configuration => :Release
  msb.targets :Build
  msb.solution = SOLUTION_FILE
end

nunit :tests => [:build] do |cmd|
  cmd.command = "src/packages/NUnit.Runners.2.6.3/tools/nunit-console.exe"
  cmd.assemblies = FileList["src/Tests/bin/Release/Tests.dll"]
end

zip :package => [:build] do |zip|
  zip.directories_to_zip = ["src/Code/bin/Release"]
  zip.output_file = PACKAGE_FILE
  zip.output_path = OUTPUT_DIRECTORY
end

task :teamcity => [:package]