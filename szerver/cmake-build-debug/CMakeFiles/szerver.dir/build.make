# CMAKE generated file: DO NOT EDIT!
# Generated by "MinGW Makefiles" Generator, CMake Version 3.12

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = "C:\Program Files\JetBrains\CLion 2018.2.6\bin\cmake\win\bin\cmake.exe"

# The command to remove a file.
RM = "C:\Program Files\JetBrains\CLion 2018.2.6\bin\cmake\win\bin\cmake.exe" -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = C:\Users\farka\Desktop\halozatok\chat\szerver

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = C:\Users\farka\Desktop\halozatok\chat\szerver\cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/szerver.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/szerver.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/szerver.dir/flags.make

CMakeFiles/szerver.dir/main.cpp.obj: CMakeFiles/szerver.dir/flags.make
CMakeFiles/szerver.dir/main.cpp.obj: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=C:\Users\farka\Desktop\halozatok\chat\szerver\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/szerver.dir/main.cpp.obj"
	C:\MinGW\bin\g++.exe  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles\szerver.dir\main.cpp.obj -c C:\Users\farka\Desktop\halozatok\chat\szerver\main.cpp

CMakeFiles/szerver.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/szerver.dir/main.cpp.i"
	C:\MinGW\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E C:\Users\farka\Desktop\halozatok\chat\szerver\main.cpp > CMakeFiles\szerver.dir\main.cpp.i

CMakeFiles/szerver.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/szerver.dir/main.cpp.s"
	C:\MinGW\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S C:\Users\farka\Desktop\halozatok\chat\szerver\main.cpp -o CMakeFiles\szerver.dir\main.cpp.s

# Object files for target szerver
szerver_OBJECTS = \
"CMakeFiles/szerver.dir/main.cpp.obj"

# External object files for target szerver
szerver_EXTERNAL_OBJECTS =

szerver.exe: CMakeFiles/szerver.dir/main.cpp.obj
szerver.exe: CMakeFiles/szerver.dir/build.make
szerver.exe: CMakeFiles/szerver.dir/linklibs.rsp
szerver.exe: CMakeFiles/szerver.dir/objects1.rsp
szerver.exe: CMakeFiles/szerver.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=C:\Users\farka\Desktop\halozatok\chat\szerver\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable szerver.exe"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\szerver.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/szerver.dir/build: szerver.exe

.PHONY : CMakeFiles/szerver.dir/build

CMakeFiles/szerver.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles\szerver.dir\cmake_clean.cmake
.PHONY : CMakeFiles/szerver.dir/clean

CMakeFiles/szerver.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" C:\Users\farka\Desktop\halozatok\chat\szerver C:\Users\farka\Desktop\halozatok\chat\szerver C:\Users\farka\Desktop\halozatok\chat\szerver\cmake-build-debug C:\Users\farka\Desktop\halozatok\chat\szerver\cmake-build-debug C:\Users\farka\Desktop\halozatok\chat\szerver\cmake-build-debug\CMakeFiles\szerver.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/szerver.dir/depend
