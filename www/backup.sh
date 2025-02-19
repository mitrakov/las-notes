#!/bin/bash
set -e

if ! [ `which 7z` ]; then
  echo "Please install 7-zip"
  exit 1
fi

cleanup() {
  rm -r bkp/
}
trap cleanup EXIT

# MySQL
PWD=`cat .env | awk -F '[=]' '{print $2}'`
docker compose exec -i db mysqldump -uroot -p$PWD --databases wordpress > dump.sql

# Wordpress
mkdir -p bkp/
cp -r wpdata/ bkp/
find bkp/ -name "*.dmg" | xargs rm
find bkp/ -name "*.msi" | xargs rm
7z a wpdata-no-uploads.7z bkp/wpdata/
