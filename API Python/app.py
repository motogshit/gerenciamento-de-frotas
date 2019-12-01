from flask import Flask, jsonify, request
import pyodbc

conn = pyodbc.connect(
    'Driver={SQL Server};'
    'Server=DESKTOP-NTV67RE\SQLEXPRESS;'
    'Database=TheSystem;'
    'Trusted_Connection=yes;'
)

cursor = conn.cursor()

app = Flask(__name__)

@app.route('/')
def index():
    cursor.execute('SELECT * FROM dbo.funcionarios')

    retorno = []
    for row in cursor:
        retorno.append({'ID': row[0], 'Nome': row[1], 'CPF': row[3]})
        
    return jsonify(retorno)

@app.route('/', methods=['POST'])
def register():
    nome = request.json['Nome']
    sobre = request.json['Sobrenome']
    try:
        query = "Insert into aa (nome, sobrenome) values (?,?)"
        cursor.execute(query, nome, sobre)
        conn.commit()
        return "Cadastrado com sucesso!", 200
    except:
        return "Erro ao cadastrar informação", 400


@app.route('/Login', methods=['POST'])
def login():
    nome = request.json['Codigo']
    sobre = request.json['CPF']
    query = "Select * from funcionarios where ID = ? AND CPF = ?"
    cursor.execute(query, nome, sobre)

    if len(list(cursor.fetchall())) > 0:
        return "Sucesso", 200
    else:
        return "Falha no login, tente novamente!",400