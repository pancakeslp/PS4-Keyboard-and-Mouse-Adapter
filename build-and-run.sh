#!/bin/bash


## be error tollerant for process killing
set +e
echo "killing RemotePlay"
## documentation says /im but mingw no likey
taskkill.exe -im RemotePlay* -f


## stops the execution of the script if a command or pipeline has an error
set -e

./build.sh

cp manualBuild/my-mappings.json zip-temp/Release/mappings.json
cd zip-temp/Release/

./PS4KeyboardAndMouseAdapter.exe