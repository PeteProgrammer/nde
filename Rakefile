namespace :paket do
  paket_exe = "paket.exe"

  file paket_exe do
    system "mono paket.bootstrapper.exe"
  end

  desc "Downloads paket.exe"
  task :bootstrap => paket_exe
end

# Creates the concrete task for building F# code
class FscBuilder
  def initialize name
    @exe_name = name
    yield self if block_given?
  end
  
  def source_files
    @source_files ||= []
  end

  def create_task
    Rake::FileTask::define_task @exe_name => source_files do |t|
      output = "--out:#{@exe_name}"
      target = "--target:exe"
      sources = source_files.join(" ")
      system "fsharpc #{output} #{target} #{sources}"
    end
  end
end

def fsc *args, &block 
  builder = FscBuilder.new *args, &block
  builder.create_task
end

task :clean do
end

desc "Main executable"
fsc "nde.exe" do |t|
  t.source_files << "main.fs"
end

task :build => ["nde.exe"] 

task :default => [:clean, :build]
