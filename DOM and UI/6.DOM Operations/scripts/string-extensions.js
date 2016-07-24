(function() {
    if (!String.prototype.repeat) {
        String.prototype.repeat = function(times) {
            var repeatString;
            if (!times) {
                times = 1;
            }
            repeatString = "";
            for (var i = 0; i < times; i++) {
                repeatString += String(this);
            }
            return repeatString;
        };
    }

    if (!String.prototype.trimLeftChars) {
        String.prototype.trimLeftChars = function(chars) {
            var regEx = new RegExp("^[" + chars + "]+");
            return this.replace(regEx, "");
        };
    }

    if (!String.prototype.trimRightChars) {
        String.prototype.trimRightChars = function(chars) {
            var regEx = new RegExp("[" + chars + "]+$");
            return this.replace(regEx, "");
        };
    }

    if (!String.prototype.trimChars) {
        String.prototype.trimChars = function(chars) {
            return this.trimLeftChars(chars).trimRightChars(chars);
        };
    }
}());