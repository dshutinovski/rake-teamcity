require 'rspec/core/rake_task'

task :default => [:teamcity]

task :teamcity => [:build,:spec]

task :build do
	#ENV.each {|key, value| puts "#{key} = #{value}" }
end

RSpec::Core::RakeTask.new(:spec) do |t|
	#t.fail_on_error = false
end