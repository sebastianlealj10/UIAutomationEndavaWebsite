require 'rexml/document'
DOT_NET_PATH = "#{ENV["SystemRoot"]}\\Microsoft.NET\\Framework\\v3.5"
SOURCE_PATH = "../src"
CONFIG = "Release"
OUTPUT_PATH = "output"
SVN_LOG_PATH = "#{OUTPUT_PATH}/svn_log.xml"
ARTIFACTS_PATH = "#{OUTPUT_PATH}/artifacts"
SVN_URL = "http://aardvark-cms.googlecode.com/svn/trunk/"
VERSION_MAJOR_MINOR_BUILD = "0.1.0"
TEAMCITY_NUNIT_RUNNER = ENV["system.teamcity.dotnet.nunitlauncher"]
NUNIT_EXE = ENV["system.teamcity.dotnet.nunitlauncher"]
tests = FileList["#{SOURCE_PATH}/**/#{CONFIG}/UIAutomationEndavaWebsite.dll"].exclude(/obj\//)
task :default => ["build:all"]
namespace :build do
    task :all => [:compile, :test]
    desc "Build solution using MSBuild."
    task :compile do
        puts "Compiling Solution..."
        solutions = FileList["#{SOURCE_PATH}/**/*.sln"]
        solutions.each do |solution|
          sh "#{DOT_NET_PATH}/msbuild.exe /p:Configuration=#{CONFIG} #{solution} /t:Rebuild"
        end
    end   
    desc "Runs tests with NUnit only (without coverage)."
    task :test => [:compile] do
        puts "Running Tests..."
        sh "#{NUNIT_EXE} /category-exclude:Acceptance bin/Debug/netcoreapp3.0/UIAutomationEndavaWebsite.dll"
    end
end