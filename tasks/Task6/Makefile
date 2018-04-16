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

BIN=task6
SOURCES=students.cs task6.cs
MONO_PATH="./external/NUnit.ConsoleRunner.3.8.0/tools:./external/NUnit.3.10.1/lib"

all: nuget $(SOURCES)
	[ -f Newtonsoft.Json.dll ] || ln -s external/Newtonsoft.Json.11.0.2/lib/net45/Newtonsoft.Json.dll
	[ -f System.Reactive.Core.dll ] || ln -s external/System.Reactive.Core.3.1.1/lib/netstandard1.3/System.Reactive.Core.dll
	[ -f System.Reactive.Linq.dll ] || ln -s external/System.Reactive.Linq.3.1.1/lib/netstandard1.3/System.Reactive.Linq.dll
	@mcs -out:$(BIN) $(SOURCES) -r:external/Newtonsoft.Json.11.0.2/lib/net45/Newtonsoft.Json.dll && echo "Sauce compiled!"

clean:
	@-rm -rf $(BIN) ./vendor && echo "Folder cleansed!"
	$(MAKE) clean -C tests

nuget: *.config
	nuget install

tests: nuget
	$(MAKE) run -C tests

run: clean tests all
	@echo "Main program turn on"
#	@eval echo -$$___{1..20} | tr -d ' '
	@mono $(BIN)

.PHONY: clean 
