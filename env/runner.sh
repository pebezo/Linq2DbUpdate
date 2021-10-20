#!/bin/bash

run_version() {
  echo "Starting the $1 benchmark..."
  sed -i "s/$2/$1/g" /src/Linq2DbUpdate/Linq2DbUpdate.csproj
  dotnet run -c Release --project Linq2DbUpdate/Linq2DbUpdate.csproj >> $1.txt
  grep -E "\|.+?Large_|\|.+?Method|\|---" $1.txt
}

declare -a StringArray=("3.5.0" "2.9.8" "3.4.5")

old="3.5.0"
for i in ${StringArray[@]}; do
    run_version "$i" "$old"
    old=$i
done