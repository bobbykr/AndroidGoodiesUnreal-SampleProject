// Copyright (c) 2018 Nineva Studios

#pragma once

#include "CoreMinimal.h"
#include "Blueprint/UserWidget.h"
#include "AppMenuWidget.generated.h"

/**
 * This class is representation of app menu widget.
 *
 * Its main purpose is to demonstrate how to use 
 * Android Goodies code plugin in C++ rather than in blueprints.
 *
 */
UCLASS()
class ANDROIDGOODIESTEST_API UAppMenuWidget : public UUserWidget
{
	GENERATED_BODY()	
	
protected:

	UFUNCTION(BlueprintCallable, Category = "AndroidGoodies")
	void HandleButton1Click();

	UFUNCTION(BlueprintCallable, Category = "AndroidGoodies")
	void HandleButton2Click();
};
