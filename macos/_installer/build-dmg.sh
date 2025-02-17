#!/bin/bash

# https://github.com/create-dmg/create-dmg
if ! [ `which create-dmg` ]; then
    echo "Please install: brew install create-dmg"
    exit 1
fi

if [ "$#" -ne 1 ]; then
    echo "Usage:   $0 version"
    echo "Example: $0 1.2.3"
    exit 2
fi


create-dmg \
  --volname "Las Notes Installer" \
  --volicon "appicon.png" \
  --background "background.jpg" \
  --window-size 600 400 \
  --text-size 16 \
  --icon-size 100 \
  --icon "Las Notes.app" 185 165 \
  --app-drop-link 400 165 \
  "lasnotes-macos-1.0.0.dmg" \
  "App/"
