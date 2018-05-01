from my_app import db

# ----------------- SQL Tables -----------------
class Product(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(300))
    horsepower = db.Column(db.Integer)
    price = db.Column(db.Float)
    rating = db.Column(db.Integer)
    origin = db.Column(db.String(300))
    mpg = db.Column(db.Integer)
    manufacturer = db.Column(db.String(300))
    founded = db.Column(db.Integer)
    image = db.Column(db.String(300))
    category_id = db.Column(db.Integer)   
    category_id = db.Column(db.Integer, db.ForeignKey('category.id'))
    category = db.relationship('Category', backref=db.backref('products', lazy='dynamic')
    )

class Category(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(200))


