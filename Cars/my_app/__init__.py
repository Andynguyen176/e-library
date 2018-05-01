import os
from flask import Flask
from flask.ext.sqlalchemy import SQLAlchemy

app = Flask(__name__)

file_path = os.path.abspath(os.getcwd())+"/Swift.sqlite"

app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///'+file_path

db = SQLAlchemy(app)

from my_app.source.cars3 import my_view
app.register_blueprint(my_view)

db.create_all()

