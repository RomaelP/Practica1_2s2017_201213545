from flask import Flask, request, Response
from ListaSimple import ListaSimple
from Pila import Pila
from Nodo import Nodo
from EsCola import Cola
from NodoCola import NodoCola


lista1 = ListaSimple()
pilaSignos = Pila()
pilaNumero = Pila()
colaMensajeRecibido = Cola();

app = Flask("EDD_codigo_ejemplo")

class WebService():  #Servidor
    """metodo recibe tres parametros y devuelve un texto de 
    confirmacion, agrega los parametros recibidos a la lista"""
    @app.route('/guardarListaS',methods=['POST'])
    def guardarLista():
        carnet = str(request.form["carnet"])
        ip = str(request.form["ip"])
        mascara = str(reques.form["mascara"])
        lista1.insertar(carnet, ip, mask)
        return "El carnet "+str(carnet)+" fue agregado a la lista"
    
    """metodo GET que devuelve el carnet con el nombre de funcion
    conectado"""
    @app.route('/conectado',methods=['GET'])
    def activo():
        return "201213545"
    
    """metodo POST que verifica la IP y devuelve el carnet si 
    la ip requerida esta conectad"""
    @app.route('/agregarCarnet',methods=['POST']) 
    def AgregarCarnet():
        ip = str(request.form['ip'])
        carnet = str(request.form['carnet'])
        lista1.modificarLista(ip, carnet)       
        return "Carnet agregado correctamente"
    
    @app.route('/SizeCola',methods=['GET'])
    def size():
        if colaMensajeRecibido.sizeCola != None:
            return colaMensajeRecibido.sizeCola
        else:
            return ""
    
    
    """metodo Post recibe como parametro un *inorden* y opera
    devuelve un valor, resultado de la operacion"""   
    @app.route('/operarExpresion',methods=['GET'])
    def Resolver():
        ip = colaMensajeRecibido.obtenerIP() #listo
        cadena = colaMensajeRecibido.sacarCola() #listo
        carnet = lista1.obtenerCarnet(ip)
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
        r = str(carnet) +"$"+str(ip)+"$"+str(respuesta)+"$"+str(cadena)
        #r = str(respuesta)
        #res = r + " ip: " + ipRecup
        return r        
    
    """recibe un texto y manda a guardar en una lista, devuelve
    un true para verificar que recibio el mensaje"""
    @app.route('/mensaje',methods=['POST'])
    def metodoCola():
        mensaje = str(request.form["inorden"])
        #carnet = str(requesrt.form["carnet"])
        ipRecup = str(request.environ['REMOTE_ADDR'])
        colaMensajeRecibido.agregarCola(mensaje, ipRecup," ")#mandar a guardar en la cola, parametros son mensaje e IP, carnet,
        print("mensaje "+str(mensaje)+ " ip de envio "+str(ipRecup))
        return "true"   
        
    
    if __name__ == "__main__":
        app.run(debug=True, host='192.168.0.21')