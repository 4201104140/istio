#!/bin/bash

set -ox errexit

display_usage() {
    echo
    echo "USAGE: ./build-services.sh <version> <prefix> [-h|--help]"
    echo "    -h|--help: Prints usage information"
    echo "    version:   Version of the sample app images (Required)"
    echo "    prefix:    Use the value as the prefix for image names (Required)"
}

