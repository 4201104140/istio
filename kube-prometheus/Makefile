SHELL=/bin/bash -o pipefail

BIN_DIR?=$(shell pwd)/tmp/bin

MDOX_BIN=$(BIN_DIR)/mdox
JB_BIN=$(BIN_DIR)/jb
GOJSONTOYAML_BIN=$(BIN_DIR)/gojsontoyaml
JSONNET_BIN=$(BIN_DIR)/jsonnet
JSONNETLINT_BIN=$(BIN_DIR)/jsonnet-lint
JSONNETFMT_BIN=$(BIN_DIR)/jsonnetfmt
KUBECONFORM_BIN=$(BIN_DIR)/kubeconform
KUBESCAPE_BIN=$(BIN_DIR)/kubescape
TOOLING=$(JB_BIN) $(GOJSONTOYAML_BIN) $(JSONNET_BIN) $(JSONNETLINT_BIN) $(JSONNETFMT_BIN) $(KUBECONFORM_BIN) $(MDOX_BIN) $(KUBESCAPE_BIN)

JSONNETFMT_ARGS=-n 2 --max-blank-lines 2 --string-style s --comment-style s

MDOX_VALIDATE_CONFIG?=.mdox.validate.yaml
MD_FILES_TO_FORMAT=$(shell find docs developer-workspace examples experimental jsonnet manifests -name "*.md") $(shell ls *.md)





$(TOOLING): $(BIN_DIR)
	@echo Installing tools from scripts/tools.go
	@cd scripts && cat tools.go | grep _ | awk -F'"' '{print $$2}' | xargs -tI % go build -modfile=go.mod -o $(BIN_DIR) %