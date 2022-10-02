using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traductor_de_simbolos.Simbolos
{
    // Clase traductor de símbolos.
    internal class TraductorSimbolos
    {     
        // Arreglos de entrada y salida de datos.
        string entrada;
        string salida;
        // Declaración de atributos.
        public string Entrada
        {
            get {return entrada;}
            set {entrada = value;}
        }
        public string Salida
        {
            get{return salida;}
            set{salida = value;}
        }
        // Variable auxiliar declarada.
        public string aux1 = null;
        // Delimitador para el programa (este será un espacio).
        public char delimitador = ' ';
        // Arreglo con significado de símbolos.
        public string[] traduccion = { " ",
            "número cero","número uno","número dos","número tres","número cuatro",
            "número cinco","número seis","número siete","número ocho","número nueve",

            "letra a minúscula","letra b minúscula","letra c minúscula","letra d minúscula","letra e minúscula",
            "letra f minúscula","letra g minúscula","letra h minúscula","letra i minúscula","letra j minúscula",
            "letra k minúscula","letra l minúscula","letra m minúscula","letra n minúscula","letra ñ minúscula",
            "letra o minúscula","letra p minúscula","letra q minúscula","letra r minúscula","letra s minúscula",
            "letra t minúscula","letra v minúscula","letra w minúscula","letra x minúscula","letra y minúscula",
            "letra z minúscula",

            "letra C mayúscula","letra D mayúscula","letra E mayúscula","letra F mayúscula","letra G mayúscula",
            "letra H mayúscula","letra I mayúscula","letra J mayúscula","letra K mayúscula","letra L mayúscula",
            "letra M mayúscula","letra N mayúscula","letra Ñ mayúscula","letra O mayúscula","letra P mayúscula",
            "letra Q mayúscula","letra R mayúscula","letra S mayúscula","letra T mayúscula","letra U mayúscula",
            "letra V mayúscula","letra W mayúscula","letra X mayúscula","letra Y mayúscula","letra Z mayúscula",

            "diagonal", "coma", "acento", "gamma minúscula","punto y coma",
            "asterisco","guion/menos","guion bajo","arroba","dos puntos",
            "punto","igualdad","mayor","menor","mayor igual",
            "menor igual", "Flecha arriba abajo con base", "Flecha hacia abajo","Flecha hacia arriba","delta minúscula",
            "gamma mayúscula","alpha mayúscula/letra A mayúscula","alpha minúscula","beta mayúscula/letra B mayúscula","beta minúscula",
            "delta mayúscula","más/suma", "Flecha hacia la derecha","Flecha hacia la izquierda ","Flecha hacia la izquierda y derecha",
            "parentesis de apertura","parentesis de cierre","interrogación de apertura","interrogación de cierre","sección/párrafo",
            "corchete de apertura","corchete de cierre","diagonal invertida","dólar","grado",
            "admiración","exclamación","numeral","ligadura/conjunción","porcentaje",
            "comillas dobles","apóstrofo","negación","infinito","épsilon",
            "gancho/función","intersección","unión","unión/letra u minúscula","no igualdad",
            "virgulilla","acento circunflejo","copyrigth","marca registrada","más menos",
            " "};
        // Arreglo con símbolos 
        public string[] simbolo = {" ",
            "0","1","2","3","4",
            "5","6","7","8","9",

            "a","b","c","d","e",
            "f","g","h","i","j",
            "j","l","m","n","ñ",
            "o","p","q","r","s",
            "t","v","w","x","y",
            "z",

            "C","D","E","F","G",
            "H","I","J","J","L",
            "M","N","Ñ","O","P",
            "Q","R","S","T","U",
            "V","W","X","Y","Z",

            "/",",","´","γ",";",
            "*","-","_","@",":",
            ".","=",">","<","≥",
            "≤","↨","↓","↑","δ",
            "Γ","A","α","B","β",
            "Δ","+","→","←","↔",
            "(",")","¿","?","§",
            "[","]","\\","$","°",
            "!","¡","#","&","%",
            "\"","'","¬","∞","ε",
            "ƒ","∩","∪","u","≠",
            "~","^","©","®","±",
            " "};      
        // Método para traducir el símbolo ingresado en teclado.
        public string TraducirSimbolo ()
        {
            // Variable auxiliar para guardar palabras a desplegar.
            aux1 = null;
            // Delimitación de palabras en arreglo entrada.
            string[] valores = entrada.Split(delimitador);
            // Contador de valores de entrada en el programa, se pone de forma decremental
            // para que al momento de desplegar los datos estos aparezcan en el orden correcto.
            for (int i = valores.Length-1; i >= 0 ; i--)
            {
                // Recorrido del arreglo de todos los simbolos del programa.
                for (int j = 0; j < simbolo.Length; j++)
                {
                    // Comparativa de igualdad entre el arreglo de valores ingresados y los símbolos
                    // que ya están en el programa.
                    if (valores[i] == simbolo[j])
                    {
                        // Se establece que la salida de datos será igual a las palabras que se
                        // encuentran en el arreglo de traducción en la posición del contador j.
                        salida =  traduccion[j];
                    }
                    // En el caso de que el símbolo no se encuentre en el sistema, este desplegara
                    // el mensaje de "No se encontro".
                    if (j < simbolo.Length-simbolo.Length+1)
                    {
                        salida = "No se encontro";
                    }
                }
                // A la variable auxiliar se le asigna la salida concatenada con la misma variable.
                aux1 = "| " +  salida + " " + aux1;
            }
            // Se limpian el arreglo de datos ingresados.
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = null;
            }
            // tambien se limpia la salida
            salida = null;
            // Se retorna la variable auxiliar concatenada con el símbolo |
            return aux1 + "|";
        }
    }
}