BIN=hello
SOURCES=hello.cs

all: $(SOURCES)
	mcs -out:$(BIN) hello.cs && echo "Source compiled"

clean:
	@-rm -rf $(BIN)

run: all
	mono $(BIN)

.PHONY: clean 
