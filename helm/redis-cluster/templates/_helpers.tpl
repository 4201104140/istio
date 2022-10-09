{{/* vim: set filetype=mustache: */}}

{{/*
Return the proper Redis&reg; image name
*/}}
{{- define "redis-cluster.image" -}}
{{ include "common.images.image" (dict "imageRoot" .Values.image "global" .Values.global) }}
{{- end -}}

{{/*
Determines whether or not to create the Statefulset
*/}}
{{- define "redis-cluster.createStatefulSet" -}}
    {{- if not .Values.cluster.externalAccess.enabled -}}
        {{- true -}}
    {{- end -}}
    {{- if and .Values.cluster.externalAccess.enabled .Values.cluster.externalAccess.service.loadBalancerIP -}}
        {{- true -}}
    {{- end -}}
{{- end -}}