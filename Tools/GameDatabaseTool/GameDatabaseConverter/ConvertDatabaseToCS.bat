SET CONVERTERPATH=.\bin\Debug\GameDatabaseConverter.exe
SET INFOLDER=..\..\..\GameDatabase\
SET OUTFOLDER=.\out\

%CONVERTERPATH% %INFOLDER%CraftingData.csv %OUTFOLDER%CraftingData.cs CraftingData
%CONVERTERPATH% %INFOLDER%CraftingMatsData.csv %OUTFOLDER%CraftingMatsData.cs CraftingMatsData
%CONVERTERPATH% %INFOLDER%EquipmentData.csv %OUTFOLDER%EquipmentData.cs EquipmentData
%CONVERTERPATH% %INFOLDER%ExpTable.csv %OUTFOLDER%ExpTable.cs ExpTable
%CONVERTERPATH% %INFOLDER%GambitData.csv %OUTFOLDER%GambitData.cs GambitData

%CONVERTERPATH% %INFOLDER%HeroesData.csv %OUTFOLDER%HeroesData.cs HeroesData
%CONVERTERPATH% %INFOLDER%LevelData.csv %OUTFOLDER%LevelData.cs LevelData
%CONVERTERPATH% %INFOLDER%MobData.csv %OUTFOLDER%MobData.cs MobData
%CONVERTERPATH% %INFOLDER%SkillData.csv %OUTFOLDER%SkillData.cs SkillData
