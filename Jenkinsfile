pipeline {
    agent any

   

    stages {
        stage('Build') {
            steps {
                script {
                    // Build Docker image
                    sh 'docker build --no-cache -t onionms/api -f OnionArchitectureInAspNetCore6WebAPI/Dockerfile .'
                }
            }
        }

        stage('Push and Deploy') {
            steps {
                script {
                    // Stop and remove existing container (if any)
                    sh 'docker stop onionms || true && docker rm onionms || true'

                    // Run a new container with the built image
                    sh 'docker run -d --name onionms -p 5003:80 --env "ASPNETCORE_ENVIRONMENT=Development" onionms/api:latest'
                }
            }
        }
    }
}
