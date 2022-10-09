# istio

curl -L https://istio.io/downloadIstio | sh -

kubectl config get-contexts
kubectl config use-context kind-istio-testing

kubectl apply -f https://raw.githubusercontent.com/kubernetes/dashboard/v2.7.0/aio/deploy/recommended.yaml

kubectl get pod -n kubernetes-dashboard

kubectl create serviceaccount -n kubernetes-dashboard admin-user
kubectl create clusterrolebinding -n kubernetes-dashboard admin-user --clusterrole cluster-admin --serviceaccount=kubernetes-dashboard:admin-user

token=$(kubectl -n kubernetes-dashboard create token admin-user)

echo $token

kubectl proxy


helm dependency build 
helm install test ./