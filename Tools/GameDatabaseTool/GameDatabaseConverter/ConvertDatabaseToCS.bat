SET CONVERTERPATH=.\bin\Debug\GameDatabaseConverter.exe
SET INFOLDER=..\..\..\GameDatabase\
SET OUTFOLDER=.\out\

%CONVERTERPATH% %INFOLDER%CraftingData.csv %OUTFOLDER%CraftingData.cs CraftingData
%CONVERTERPATH% %INFOLDER%CraftingMatsData.csv %OUTFOLDER%CraftingMatsData.cs CraftingMatsData
%CONVERTERPATH% %INFOLDER%HeroesData.csv %OUTFOLDER%HeroesData.cs HeroesData
