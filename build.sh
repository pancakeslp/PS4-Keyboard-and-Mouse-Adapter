#!/bin/bash

## stops the execution of the script if a command or pipeline has an error
set -e

ARCHIVE_FILE="PS4KeyboardAndMouseAdapter-bundle.tar.gz"
PATH="$PATH:/c/Program Files (x86)/Microsoft Visual Studio/2019/Community/MSBuild/Current/Bin/amd64/"

function cleanup {
  rm -rf PS4KeyboardAndMouseAdapter/bin/Release
  rm -rf zip-temp

  ## dont add  rm -rf $ARCHIVE_FILE here
  ## we call cleanup at the end of successful build
  ## if you add that here the build will have been pointless
}

## make sure we are in the directory of this file
cd $( dirname $0 )

cleanup
rm -rf $ARCHIVE_FILE
 

MSBuild.exe PS4KeyboardAndMouseAdapter.sln -p:Configuration=Release


mkdir zip-temp
cp -r PS4KeyboardAndMouseAdapter/bin/Release zip-temp/
cp  manualBuild/csfml-Window.dll             zip-temp/Release/
cp  manualBuild/default-mappings.json        zip-temp/Release/mappings.json

cd zip-temp
tar -cf  ../$ARCHIVE_FILE Release/* --gzip

cleanup

echo "SUCCESS: made $ARCHIVE_FILE"
