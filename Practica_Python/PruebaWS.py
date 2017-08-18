from flask import Flask, request, Response
from ListaSimple import ListaSimple
from Pila import Pila
from Nodo import Nodo


lista1 = ListaSimple()
pilaSignos = Pila()
pilaNumero = Pila()


app = Flask("EDD_codigo_ejemplo")

class WebService():  
    
    @app.route('/guardarListaS',methods=['POST'])
    def guardarLista():
        carnet = str(request.form["carnet"])
        ip = str(request.form["ip"])
        mascara = str(reques.form["mascara"])
        return "El carnet "+str(carnet)+" fue agregado a la lista"
    
    @app.route('/conectado',methods=['GET'])
    def activo():
        return "201213545"
    
    @app.route('/agregarCarnet',methods=['POST']) 
    def AgregarCarnet():
        ip = str(request.form['ip'])
        carnet = str(request.form['carnet'])
        lista1.modificarLista(ip, carnet)       
        return "Carnet agregado correctamente"
    
        
    @app.route('/operarExpresion',methods=['POST'])
    def ResolverExpresion():
        cadena = str(request.form['inorden'])
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
        return r        
    
    
    @app.route('/mensaje',methods=['POST'])
    def metodoCola():
        mensaje = str(request.form["inorden"])
        ipRecup = str(request.environ['REMOTE_ADDR'])
        print("mensaje "+str(mensaje)+ " ip de envio "+str(ipRecup))
        return "true"   
        
    
    if __name__ == "__main__":
        app.run(debug=True, host='192.168.10.104')