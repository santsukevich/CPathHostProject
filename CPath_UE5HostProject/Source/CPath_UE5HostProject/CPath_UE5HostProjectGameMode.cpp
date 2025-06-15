// Copyright Epic Games, Inc. All Rights Reserved.

#include "CPath_UE5HostProjectGameMode.h"
#include "Kismet/GameplayStatics.h"
#include "CPathVolume.h"

ACPath_UE5HostProjectGameMode::ACPath_UE5HostProjectGameMode()
{
}

void ACPath_UE5HostProjectGameMode::BeginPlay()
{
	UGameplayStatics::GetActorOfClass(this, ACPathVolume::StaticClass());
	UE_LOG(LogTemp, Warning, TEXT("GAMEMODE ENTERED"));
}
