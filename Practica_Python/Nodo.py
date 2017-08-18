

class Nodo ():
    def __init__ (self, carnet = None, ip = None, mask = None, siguiente = None):
        self.carnet = carnet
        self.ip= ip
        self.mask= mask
        self.siguiente = siguiente
    
    def __str__(self):
        return str(self.carnet + self.ip + self.mask)