let database = function () {
    let records,
        lastId,
        self;

        function findRecordById(id){
            let record;
            if (!records) {
                return null;
            }
            for(let i = 0; i < records.length; i+= 1){
                record=records[i];
                if (record.id===id) {
                    return record;
                }
            }
            return null;
        }
        function saveRecord(record){
            if (!lastId) {
                lastId=0;
            }
            if (!records) {
                records=[];
            }
            record.id=lastId+=1;
            records.push(record);
            return this;
        }

        function getAllRecords(){
            let cloneRecords=[];
            for(let i = 0; i < records.length; i+= 1){
                cloneRecords[i]=records[i];
            }
            return cloneRecords;
        }
        self={
            save:saveRecord,
            findById:findRecordById,
            getAll:getAllRecords
        };
        return self;
}();
database.save({
	name: 'Peter',
	age: 13
}).save({
	name: 'Gosho',
	age: 17
}).save(database);

console.log(database.getAll());
console.log(database.findById(3));