diff \
  <(kubectl kustomize build kustomize/examples/helloWorld/staging) \
  <(kubectl kustomize build $OVERLAYS/production) |\
  more