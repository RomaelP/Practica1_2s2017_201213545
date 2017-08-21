from Nodo import Nodo

class ListaSimple():
    def __init__(self):
        self.inicio = None
        
    def insertar(self, carnet, ip, mask): #metodo agregar se llena con los nodos que vengan del metodo post de el WS
        if (self.inicio !=None):
            temp = self.inicio
            while temp.siguiente != None:
                temp = temp.siguiente
                
            nuevoNodo = Nodo(carnet, ip, mask, None)
            temp.siguiente = nuevoNodo
            
        else:
            nuevoNodo = Nodo(carnet, ip, mask, None)
            self.inicio = nuevoNodo
    
    def mostrar(self):
        temp = self.inicio
        print("\nLos datos de la lista son: ")
        while temp != None:
            print("Ip: "+str(temp.ip)+" Carnet: " +temp.carnet)
            temp = temp.siguiente
            
    def obtenerCarnet(self, ip):
        if self.inicio != None:
            temp = self.inicio
            while temp != None:
                if temp.ip == ip:
                    return temp.carnet
                temp = temp.siguiente    
            
    def size(self):
        return self.contador
    