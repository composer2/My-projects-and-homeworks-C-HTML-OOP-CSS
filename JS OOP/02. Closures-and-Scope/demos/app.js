var database = function () {
    var records,
        lastId,
        self;

    function findRecordById(id) {
        var i,
            record;
        if (!records) {
            return null;
        }
        for (i = 0, len = records.length; i < len; i += 1) {
            record = records[i];
            if (record.id === id) {
                return record;
            }
        }
        return null;
    }

    function saveRecord(record) {
        if (!lastId) {
            lastId = 0;
        }
        if (!records) {
            records = [];
        }
        record.id = ++lastId;
        records.push(record);
        return self;
    }

    function getAllRecords() {
        var cloneRecords,
            i;
        cloneRecords = [];
        cloneRecords[records.length - 1] = undefined;
        for (i = 0, len = records.length; i < len; i += 1) {
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
    name:'Peter',
    age:13
}).save({
    name:'Goshko',
    age:21
}).save(database);

console.log(database.getAll());
//console.log(database.findById(3));