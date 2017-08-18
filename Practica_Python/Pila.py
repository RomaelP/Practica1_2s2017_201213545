from nodoPila import nodoPila

class Pila():
    def __init__(self):
        self.ultimo = None
        
    def agregarPila(self, dato):
        if self.ultimo != None:
            temp = self.ultimo
            self.ultimo = nodoPila(dato)
            self.ultimo.sig = temp
        else:
            self.ultimo = nodoPila(dato)
            
    def sacarPila(self):
        if self.ultimo != None:
            temp = self.ultimo
            self.ultimo = temp.sig
            return temp.numero
        
        
        