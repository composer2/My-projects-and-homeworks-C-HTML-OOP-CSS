var categories = [];
var book=[];
book.category="Pesho";


function setupCategory(categories, book) {
			var category = {};
			category.ID = categories.length + 1;
			category.title = book.category +" "+(categories.length+1);

			categories.push(category);
		}
setupCategory(categories,book);
setupCategory(categories,book);
setupCategory(categories,book);
item=book.category;
console.log("Im book "+item);
console.log(categories);
console.log(categories[0].title);