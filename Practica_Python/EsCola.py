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
                
                
            nuevoNodo = NodoCola (mensaje, ip, carnet, None)
            self.cont = self.cont+1
            temp.siguiente = nuevoNodo
            
        else:
            nuevoNodo = NodoCola(mensaje, ip, carnet, None)
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
    def crearArchivo():
        archivo = open('graficarCola.txt','w')
        archivo.close()
    
    def escribirArchivo():
        temp = self.inicio
        contador1=0
        archivo = open('graficarCola.txt','a')
        archivo.write('digraph G,{\n')
        while temp != None:
            archivo.write("nodo"+str(contador1)+"[label=<"+str(temp.ip)+" "+str(temp.mensaje)+">]\n")
            contador1=contador1+1
            temp=temp.siguiente
        contador1=0
        contador2=1
        temp = self.inicio
        while temp!=None:
            if temp.siguiente != None:
                archivo.write("nodo_"+str(contador1)+"->"+"nodo_"+str(contador2)+"\n")
                contador1 = contador1+1
                contador2 = contador2+1
            temp = temp.siguiente
        archivo.write('}')
        archivo.close()
        return "graficaCola"
        
        
        