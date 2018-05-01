from flask import request, Blueprint
from flask import render_template
from sqlalchemy.orm.util import join
#from my_app import app

my_view = Blueprint('my_view', __name__)
from my_app.source.vehicles import Product, Category

# ----------------- Homepage -----------------
@my_view.route('/')
@my_view.route('/home')
def home():
    return render_template('home.html')

# ----------------- Production Page -----------------
@my_view.route('/production/<id>', methods=['GET','POST'])
def product(id):
    index = int(id)
    products = Product.query.all()
    return render_template('test1.html',products = products, id = index)

# ---------------- All car page ------------------------                 
@my_view.route('/productions', methods=['GET', 'POST'])
@my_view.route('/productions/<int:page>')
def products(page=1):
  products = Product.query.all()
  categories = Category.query.all()
  return render_template('test2.html', products = products, categories = categories)

# ----------------- Category Page -----------------
@my_view.route('/category/<id>')
def category(id):
    index = int(id)
    categories = Category.query.all()
    return render_template('test3.html', categories = categories, id = index)

# ---------------- All category page
@my_view.route('/categories')
def categories():
    categories = Category.query.all()
    return render_template('test4.html', categories = categories)

# ----------------- Search Function -----------------
@my_view.route('/product-search')
def product_search(page=1):
    name = request.args.get('name')
    price = request.args.get('price')
    rating = request.args.get('rating')
    origin = request.args.get('origin')
    mpg = request.args.get('mpg')
    manufacturer = request.args.get('manufacturer')
    founded = request.args.get('founded')
    price_greater_equal = request.args.get('price_ge')
    price_smaller_equal = request.args.get('price_se')
    horsepower_greater_equal = request.args.get('horsepower_ge')
    horsepower_smaller_equal = request.args.get('horsepower_se')
    
    products = Product.query
    if name:
        products = products.filter(Product.name.like('%' + name + '%'))
    if horsepower_greater_equal:
        products = products.filter(Product.horsepower.between(price_greater_equal,10000))
    if horsepower_smaller_equal:
        products= products.filter(Product.horsepower.between(0, price_smaller_equal))
    if price_greater_equal:
        products = products.filter(Product.price.between(price_greater_equal,1000000))
    if price_smaller_equal:
        products = products.filter(Product.price.between(0, price_smaller_equal))
    if rating:
        products = products.filter(Product.rating.like('%' + rating + '%'))
    if origin:
        products = products.filter(Product.origin.like('%' + origin + '%')) 
    if mpg:
        products = products.filter(Product.mpg.like('%' + mpg + '%'))
    if manufacturer:
        products = products.filter(Product.manufacturer.like('%' + manufacturer + '%'))
    if founded:
        products = products.filter(Product.founded.like('%' + founded + '%'))
        
    return render_template('test2.html', products = products)
    
# ------------- About us page ------------------
@my_view.route('/OVOabout')
def about():
    return render_template ('test5.html')


