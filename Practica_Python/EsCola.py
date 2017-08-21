from NodoCola import NodoCola

class Cola:
    def __init__(self):
        self.inicio = None;
        self.cont = 0;
        
    def agregarCola(self, mensaje, ip, carnet):
        if (self.inicio != None):
            temp = self.inicio
            while temp.siguiente != None:
                temp = temp.siguiente
                
                
            nuevoNodo = NodoCola (mensaje, ip, None)
            self.cont = self.cont+1
            temp.siguiente = nuevoNodo
            
        else:
            nuevoNodo = NodoCola(mensaje, ip, None)
            self.cont = self.cont+1
            self.inicio= nuevoNodo
            
    def mostrarElementosCola(self):
        temp = self.inicio
        print("\n los elementos en la cola son: ")
        while temp != None:
            print("mensaje: "+str(temp.mensaje)+" ip: "+str(temp.ip))
            temp = temp.siguiente
                
    def sizeCola(self):
        return self.cont
    
    def sacarCola(self):
        if self.inicio != None:
            temp = self.inicio
            self.inicio = temp.siguiente
        return str(temp.mensaje)
    
    def obtenerIP(self):
        if self.inicio != None:
            temp = self.inicio
            return temp.ip
        