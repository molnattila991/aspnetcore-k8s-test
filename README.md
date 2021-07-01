# aspnetcore-k8s-test

- This repository contains two ASP.NET Core API
- API-2 uses API-1 to get data
- APIs can be run with Docker Compose or Kubernetes
- API-1 and API-2 has it's own deployment and service file
- API-1 and API-2 has it's own docker file

# Run with Docker Compose 
- Go into docker-compose folder
- Run the following command "docker-compose up --build" in your terminal
- Open http://localhost:19998/weatherforecast in browser

# Run with Minikube
- Build container images with tag 'api-1:v1' and 'api-2:v2'
- Be sure to use the proper docker registry (run command 'minikube docker-env' in your terminal)
- Go into k8s folder
- Run the following command "kubectl apply -f ./deployment.yml"
- All deployment.yml and service.yml are merged into one deployment.yml file. The merge is not automatic, so in case of change of any deployment or service file, you should update the merged deployment.yml file as well.
