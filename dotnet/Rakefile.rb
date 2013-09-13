require 'albacore'

msbuild :build_release do |msb|
  msb.properties :configuration => :Release
  msb.targets :Build
  msb.solution = 'Project.sln'
end

task :teamcity => [:build_release]