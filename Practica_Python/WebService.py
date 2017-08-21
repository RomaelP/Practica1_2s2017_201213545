from flask import Flask, request, Response
from ListaSimple import ListaSimple
from Pila import Pila
from Nodo import Nodo


lista1 = ListaSimple()
pilaSignos = Pila()
pilaNumero = Pila()


app = Flask("EDD_codigo_ejemplo")

class WebService():  
    
    @app.route('/NombreMetodoPython',methods=['POST']) 
    def metodoPost():
        cadenaString = str(request.form['parametro1'])
        dato = cadenaString.split("/")
        num = len(dato)
        ip = ""
        mascara =  ""
        for i in range(num):
            if ip == "":
                ip = dato[i]
            else:
                mascara = dato[i]
                lista1.agregarLista(ip, mascara)
                ip = ""                        
            
        return "Repuesta de Python " + cadenaString
    
    @app.route("/conectado")
    def metodoGet():
        return "201212558"
    
    @app.route('/agregarCarnet',methods=['POST']) 
    def AgregarCarnet():
        ip = str(request.form['ip'])
        carnet = str(request.form['carnet'])
        lista1.modificarLista(ip, carnet)       
        return "Carnet agregado correctamente"
    
        
    @app.route('/operarExpresion',methods=['POST'])
    def ResolverExpresion():
        cadena = str(request.form['inorden'])
        self.operarExpresion(cadena)
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
                nada = " "
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
        ipRecup = str(request.environ['REMOTE_ADDR'])
        r = str(respuesta)
        res = r + " ip: " + ipRecup
        return r        
    
    
    @app.route('/mensaje',methods=['POST']) 
    def Mensaje():
        cadenaMensaje = str(request.form['inorden'])
        ipRecup = str(request.environ['REMOTE_ADDR'])
        cola.agregarCola(cadenaMensaje, ipRecup) 
        responder = "true"
        return responder    
        
    
    if __name__ == "__main__":
        app.run(debug=True, host='192.168.0.29')    