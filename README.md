Testing .NET 5 with C# 8 projects
=================================

This contains a VS Code setup to play with the latest .NET preview.

Using this project
------------------

1. Install VS Code
1. Install Docker Desktop (make sure to enable Resources > File sharing on windows to allow the disk you have your project on to be mounted)
1. Install the VS Code Remote Development Extensions
1. Clone this project
1. From VS Code do:
   1. [CTRL]+[SHIFT]+P
   1. Start> Remote-Containers: Open Folder in Container...
   1. Choose the cloned project folder

You should be able to run the tests for the console app and have a startup project for the web application. To prevent warnings about the certificate when using the web project, install the certificate as a trusted root and open https://localhost:5001 or simply proceed with warnings accepted.
