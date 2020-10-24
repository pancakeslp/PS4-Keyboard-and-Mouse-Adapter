#!/bin/bash

## stops the execution of the script if a command or pipeline has an error
set -e

./build.sh

cp manualBuild/my-mappings.json zip-temp/Release/mappings.json
cd zip-temp/Release/

./PS4KeyboardAndMouseAdapter.exe