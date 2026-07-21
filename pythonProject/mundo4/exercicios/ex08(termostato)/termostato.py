import requests
cidade = "Goiânia"

geo = requests.get(
    f"https://geocoding-api.open-meteo.com/v1/search?name={cidade}&count=1&language=pt&format=json"
).json()

lat = geo["results"][0]["latitude"]
lon = geo["results"][0]["longitude"]

clima = requests.get(
    f"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m"
).json()

class Termostato:
    def __init__(self):
        self.__termonstato = clima['current']['temperature_2m']

    @property
    def getTermostato(self):
        return self.__termonstato