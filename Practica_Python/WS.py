from flask import Flask, request, Response
from ListaSimple import ListaSimple
from Nodo import Nodo


app = Flask("EDD_codigo_ejemplo")
listaSimple = ListaSimple()
#Ejemplo de una clase, todos los metodos de las clases deben de tener como parametro el "self", que es como el .this en Java
class WebService():
    
    @app.route('/agregarListaSimple',methods=['POST']) 
    def listaAgregar(): 
        parametro1 = str(request.form['dato'])
        listaSimple.insertar(parametro1)
        return "El nombre '" + str(parametro1) + "' fue agregado con exito a la LISTA " 

    @app.route('/devolverIndiceLista',methods=['POST']) 
    def listaIndice():
        parametro1 = str(request.form['dato'])
        return "El dato '"+parametro1+"' se encuentra en el indice: " +str(listaSimple.mostrarXpos(parametro1))
    
    @app.route('/eliminarLista',methods=['POST']) 
    def listaEliminar():
        parametro1 = str(request.form['dato'])
        valor = listaSimple.eliminar(str(parametro1))
        if valor == "si":
            return "El nombre '" + str(parametro1) + "' fue eliminado con exito de la LISTA "
        elif valor == "no":
            return "NO se encontro el dato "

    @app.route("/MetodoPost")
    def hellof():
            return "Hello World2!"

    if __name__ == "__main__":
        app.run(debug=True, host='127.0.0.5')

