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

BIN=task3
SOURCES=students.cs task3.cs

all: $(SOURCES)
	@mcs -out:$(BIN) $(SOURCES) && echo "Sauce compiled!"

clean:
	@-rm -rf $(BIN) && echo "Folder cleansed!"

run: clean all
	@echo "Main program turn on"
	@eval echo -$$___{1..20} | tr -d ' '
	@mono $(BIN)

.PHONY: clean 
