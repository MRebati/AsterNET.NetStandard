[![Build Status](https://travis-ci.org/AsterNET/AsterNET.svg?branch=master)](https://travis-ci.org/AsterNET/AsterNET)
[![NuGet](https://img.shields.io/nuget/v/AsterNET.NetStandard.svg)](https://www.nuget.org/packages/AsterNET.NetStandard)

AsterNET is an open source framework for Asterisk AMI and FastAGI. AsterNET allows you to talk to Asterisk AMI from any .NET application and create FastAGI applications in any .NET language.

## Components
AsterNET is made up of two key components, FastAGI and Manager Interface. Each allows you to interact with Asterisk in different ways. FastAGI allows you to control the flow of a call from another machine (a dedicated AGI server for example) and Manager Interface allows you to obtain state information and interact with Asterisk. 

## AsterNET on IRC
Join in the conversation on Freenode, [#asternet](https://webchat.freenode.net/?channels=asternet)

## How to Get AsterNET
- Download a release: https://github.com/MRebati/AsterNET.NetStandard/releases

- Download the latest source code from GitHub project

- Download via NuGet:
> PM> Install-Package AsterNET.NetStandard

or by visiting: https://www.nuget.org/packages/AsterNET/

## Documentation
- [AsterNET Documentation](http://asternet.github.io/AsterNET)

- [Official Asterisk Documentation](https://wiki.asterisk.org/wiki/display/AST/Asterisk+14+Documentation)

## History
AsterNET.NetStandard is a fork of AsterNET. Now we've reached release status and AsterNET.NetStandard version 1.0.0 we feel this is a good separation point from the original project.