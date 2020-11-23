# Simple Guid Generator

### If you find this tool useful, please support the poor developer with some of the dependency injections below :))
#### https://www.buymeacoffee.com/kanchev07
#### https://www.patreon.com/bePatron?u=45287861
#### Or a direct injection at PayPal(better option)
#### https://paypal.me/kanchev007

### UI Available
#### http://guid-gen.com/

### Api Available
#### https://guid-gen-api.azurewebsites.net/guid

### Two simple functionalities:
#### Single Guid - Generates a single and non-empty valid Guid
#### Bulk Guid - Generates number of Guids

## Run the app

### Run it with docker
Pull the latest version:
#### `docker pull kanchev07/dev-utilities-guids:latest`

Run the image: 
#### `docker run -p 5000:80 --name guidgen -it kanchev07/dev-utilities-guids:latest`

### Or Just clone the repo and run it with visual studio

## Grab you guids

### For single guid just make a GET request to your running instance. For example:
#### `GET to => http://localhost:5000/guid`

### For many Guids just make a POST request to your running instance by adding a number of needed Guids in the body. For example:
#### `POST to => http://localhost:5000/guid with adding a number in the body(not an object, just a number)`
