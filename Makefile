SHELL = /bin/bash

.PHONY: start-cluster
start-cluster:
	./aio/scripts/start-cluster.sh

.PHONY: stop-cluster
stop-cluster:
	./aio/scripts/stop-cluster.sh