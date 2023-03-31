#!/bin/sh

set -eu

cd "$(dirname "$0")"

dotnet build com.anatawa12.harmonyfix.caller.csproj -c Release 

cp ./bin/Release/netstandard2.0/com.anatawa12.harmonyfix.caller.dll ..
