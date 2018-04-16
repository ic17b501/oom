# =====================================================================================
#
#       Filename:  Makefile
#
#    Description:  Makefile for mcs & mono
#
#        Version:  1.0.0
#        Created:  02/20/2018 09:40:05 AM
#       Revision:  none
#       Compiler:  mcs -- Mono C# compiler version 4.4.1.0
#
#         Author:  Ovidiu - Dan Bogat [ic17b501], ic17b501@technikum-wien.at
# =====================================================================================

BIN=UnitTests.dll
SOURCES=testcases.cs ../*.cs
MONO_PATH="./external/NUnit.ConsoleRunner.3.8.0/tools:./external/NUnit.3.10.1/lib:./external/System.Reactive.Core.3.1.1/lib:./external/System.Reactive.Linq.3.1.1/lib/"
NUNIT=./external/NUnit.ConsoleRunner.3.8.0/tools/nunit3-console.exe
MONO_GAC_PREFIX=~/.monogac

all: $(SOURCES)
	@mcs $(SOURCES) -target:library -r:./external/NUnit.3.10.1/lib/net45/nunit.framework.dll,./external/Newtonsoft.Json.11.0.2/lib/net45/Newtonsoft.Json.dll,./external/System.Reactive.Core.3.1.1/lib/netstandard1.3/System.Reactive.Core.dll,./external/System.Reactive.Linq.3.1.1/lib/netstandard1.3/System.Reactive.Linq.dll -out:$(BIN)

clean:
	@-rm -rf $(BIN) *.xml ./vendor && echo "Folder cleansed!"

run: clean all
	@echo "Main program turn on"
	[ -f ./nunit.framework.dll ] || ln -s ./external/NUnit.3.10.1/lib/net45/nunit.framework.dll
	[ -f ./Newtonsoft.Json.dll ] || ln -s ./external/Newtonsoft.Json.11.0.2/lib/net45/Newtonsoft.Json.dll
	[ -f System.Reactive.Core.dll ] || ln -s ./external/System.Reactive.Core.3.1.1/lib/netstandard1.3/System.Reactive.Core.dll
	[ -f System.Reactive.Linq.dll ] || ln -s ./external/System.Reactive.Linq.3.1.1/lib/netstandard1.3/System.Reactive.Linq.dll
	@mono $(NUNIT) $(BIN)

.PHONY: clean 
