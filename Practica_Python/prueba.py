from ListaSimple import ListaSimple
from Nodo import Nodo
from Pila import Pila

if __name__ == "__main__":
    print ("roma")
    pilaSignos = Pila()
    pilaNumero = Pila()
    lista = ListaSimple()
    while True:
        print("\n---- MENU ----")
        print("1. Agregar")
        print("2. Mostrar")
        print("3. probar")
        print("4. metodo operarExpresion ")
        num = input("Ingrese una opcion: ")    
        
        if num == 1: 
            dato = raw_input ("Ingrese un dato: ")
            ip = raw_input ("Ingrese un ip: ")
            mask = raw_input ("Ingrese un mask: ") 
            lista.insertar(dato, ip, mask)
        
        if num == 2:
            lista.mostrar() 
            
        if num == 3:
            #dato = raw_input ("Ingrese un dato: ")
            dato = "192.1/190.1/193.2/190.2/194.3"
            a=dato.split("/")
            #a,b,c,d,e,f = dato.split("/")
            var = len(a)
            #print("1: "+a)
            print (a[3])
            
        if num == 4:
            cadena = str(input())#str(request.form['inorden'])
            #self.operarExpresion(cadena)
            caracter = ""
            valor = ""
            numero1 = ""
            numero2 = ""
            signo = ""
            cantidad = len(cadena)
            for i in range(cantidad):
                caracter = cadena[i]
                if caracter in ('/', '*', '-', '+'):
                    pilaSignos.agregarPila(caracter)
                    pilaNumero.agregarPila(valor)
                    valor = ""
                elif caracter in (' ', '('):
                    nada = "nada"
                elif caracter == ')':
                    pilaNumero.agregarPila(valor)
                    valor = ""                   
                    numero2 = pilaNumero.sacarPila()
                    numero1 = pilaNumero.sacarPila()
                    signo = pilaSignos.sacarPila()
                    if signo == '-':
                        valor = int(numero1) - int(numero2)
                    elif signo == '+':
                        valor = int(numero1) + int(numero2)
                    elif signo == '*':
                        valor = int(numero1) * int(numero2)
                    elif signo == '/':
                        valor = int(numero1) / int(numero2)
                else:
                    valor = valor + caracter
            pilaNumero.agregarPila(valor)        
            respuesta = pilaNumero.sacarPila()
            #ipRecup = str(request.environ['REMOTE_ADDR'])
            r = str(respuesta)
            #res = r + " ip: " + ipRecup
            print(r)#return r            
                        