// Copyright Dominik Trautman. Published in 2022. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "CPathDefines.generated.h"

// TreeID settings
// If you change these, you will also need to change some masks in functions like ReplaceDepth, ExtractDepth, etc
#define DEPTH_0_BITS 21
#define DEPTH_0_LIMIT (uint32)1<<DEPTH_0_BITS
#define DEPTH_0_MASK 0x001FFFFF
#define DEPTH_MASK 0x00600000
#define MAX_DEPTH 3

// Time measurement macros
#define TIMENOW FPlatformTime::Cycles64()
// this is in ms
#define TIMEDIFF(BEGIN, END) FPlatformTime::ToMilliseconds64(END - BEGIN) 

// Uncomment these or define somewhere else to see performance logs
// #define LOG_GENERATORS 1
// #define LOG_PATHFINDERS 1 // set it to 2 for more async logs

enum ENeighbourDirection
{
	Left,	// -Y
	Front,	// -X
	Right,	// +Y
	Behind, // +X
	Below,	// -Z
	Above	// +Z
};

UENUM()
enum EAgentShape
{
	Capsule = 3,
	Box = 2,
	Sphere = 0
};

// Wrong Start and End Location mean that requested location was out of volume, or it was inside an occupied space.
UENUM()
enum ECPathfindingFailReason
{
	None,
	VolumeNotValid,
	VolumeNotGenerated,
	Timeout,
	WrongStartLocation,
	WrongEndLocation,
	EndLocationUnreachable,
	Unknown
};


