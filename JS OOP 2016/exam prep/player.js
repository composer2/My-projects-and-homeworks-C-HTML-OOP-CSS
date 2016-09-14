function solve() {
    let module = (function () {

        let currentPlayableId = 0,
            currentPlaylistId = 0,
            currentPlayerId = 0,
            validate;
        const CONSTANTS = {
            TEXT_MIN_LENGTH: 3,
            TEXT_MAX_LENGTH: 25,
            IMDB_MIN_RATING: 1,
            IMDB_MAX_RATING: 5,
            MAX_INT_NUMBER: 9007199254740992
        };
        function indexOfElementWithIdInCollection(collection, id) {
            let i, len;
            for (i = 0, len = collection.length; i < len; i += 1) {
                if (collection[i].id === id) {
                    return i;
                }
            }
            return -1;
        }
        function getSortingFunction(firstParameter, secondParameter) {
            return function (first, second) {
                if (first[firstParameter] < second[firstParameter]) {
                    return -1;
                }
                else if (first[firstParameter] > second[firstParameter]) {
                    return 1;
                }

                if (first[secondParameter] < second[secondParameter]) {
                    return -1;
                }
                else if (first[secondParameter] > second[secondParameter]) {
                    return 1;
                }
                else {
                    return 0;
                }
            }
        }
        validate = {
            validateIfObject: function (value, name = 'Value') {
                if (typeof value !== 'object') {
                    throw new Error(`${name} must be an object`);
                }
            },
            validateImdbRating: function (value) {
                this.validateIfUndefined(value, 'IMDB Rating');
                this.validateIfNumber(value, 'IMDB Rating');
                if (value < CONSTANTS.IMDB_MIN_RATING || CONSTANTS.IMDB_MAX_RATING < value) {
                    throw new Error(`IMDB Rating must be between ${CONSTANTS.IMDB_MIN_RATING} and ${CONSTANTS.IMDB_MAX_RATING}`);
                }
            },
            validateIfNumber: function (value, name = 'Value') {
                if (typeof value !== 'number') {
                    throw new Error(`${name} must be a number`);
                }
            },
            validateIfUndefined: function (value, name = 'Value') {
                if (value === undefined) {
                    throw new Error(`${name} cannot be an empty string`);
                }
            },
            validateString: function (value, name = "Value") {
                this.validateIfUndefined(value, name);
                if (typeof value !== 'string') {
                    throw new Error(`${name} must be string`);
                }
                if (value.length < CONSTANTS.TEXT_MIN_LENGTH || CONSTANTS.TEXT_MAX_LENGTH < value.length) {
                    throw new Error(`${name} must be between ${CONSTANTS.TEXT_MIN_LENGTH} and ${CONSTANTS.TEXT_MAX_LENGTH} symbols`);
                }
            },
            validatePositiveNumber: function (value, name = "Value") {
                this.validateIfUndefined(value, name);
                this.validateIfNumber(value, name);
                if (value <= 0) {
                    throw new Error(`${name} must be positive number`);
                }
            },
            validateId: function (id) {
                this.validateIfUndefined(id, 'Object id');
                if (typeof id !== 'number') {
                    id = id.id;
                }
                this.validateIfUndefined(id, 'Object must have id');
                return id;
            },
            validatePageAndSize: function (page, size, maxElements) {
                this.validateIfUndefined(page);
                this.validateIfUndefined(size);
                this.validateIfNumber(page);
                this.validateIfNumber(size);
                if (page < 0) {
                    throw new Error('Page must be a positive number');
                }
                this.validatePositiveNumber(size, 'Size');
                if (page * size > maxElements) {
                    throw new Error('Page * size wiil not return any elements from collection');
                }
            }
        };
        class Playable {
            constructor(title, author) {
                this.title = title;
                this.author = author;
                this.id = ++currentPlayableId;
                return this;
            }
            get title() {
                return this._title;
            }

            set title(value) {
                validate.validateString(value, 'Playable Title');
                this._title = value;
            }

            get author() {
                return this._author;
            }

            set author(value) {
                validate.validateString(value, 'Playable Author');
                this._author = value;
            }

            play() {
                return `${this.id}. ${this.title} - ${this.author}`;
            }
        }
        class Audio extends Playable {
            constructor(title, author, length) {
                super(title, author);
                this.length = length;
                return this;
            }
            get length() {
                return this._length;
            }
            set length(value) {
                validate.validatePositiveNumber(value, "Audio Length");
                this._length = value;
            }
            play() {
                return `${super.play()} - ${this.length}`;
            }
        }
        class Video extends Playable {
            constructor(title, author, imdbRating) {
                super(title, author);
                this.imdbRating = imdbRating;
                return this;
            }
            get imdbRating() {
                return this._imdbRating;
            }
            set imdbRating(value) {
                validate.validateImdbRating(value);
                this._imdbRating = value;
            }
            play() {
                return `${super.play()} - ${this.imdbRating}`;
            }
        }
        class PlayList {
            constructor(name) {
                this.name = name;
                this.id = ++currentPlaylistId;
                this._playables = [];
                return this;
            }
            get name() {
                return this._name;
            }
            set name(value) {
                validate.validateIfUndefined(value, "Play List");
                validate.validateString(value, "Play List");
                this._name = value;
            }
            addPlayable(playable) {
                validate.validateIfUndefined(playable, 'Playlist add playable parameter');
                validate.validateIfObject(playable, 'Playlist add playable parameter');
                validate.validateIfUndefined(playable.id, 'Playlist add playable parameter must have id');
                this._playables.push(playable);
                return this;
            }
            getPlayableById(id) {
                validate.validateIfUndefined(id, 'PlayList get playable parameter id');
                validate.validateIfNumber(id, 'PlayList get playable parameter id');
                var foundIndex = indexOfElementWithIdInCollection(this._playables, id);
                if (foundIndex < 0) {
                    return null;
                }
                return this._playables[foundIndex];
            }
            removePlayable(id) {
                id = validate.validateId(id);
                var foundIndex = indexOfElementWithIdInCollection(this._playables, id);
                if (foundIndex < 0) {
                    throw new Error(`Playable with ${id} was now found in list`);
                }
                this._playables.splice(foundIndex, 1);
                return this;
            }
            listPlayables(page = 0, size = CONSTANTS.MAX_INT_NUMBER) {
                validate.validatePageAndSize(page, size, this._playables.length);
                return this
                    ._playables
                    .slice()
                    .sort(getSortingFunction('title', 'id'))
                    .splice(page * size, size);
            }
        }
        class Player {
            constructor(name) {
                this.name = name;
                this.id = ++currentPlayerId;
                this._playlists = [];
                return this;
            }
            get name() {
                return this._name;
            }
            set name(value) {
                validate.validateIfUndefined(value, "Player name");
                validate.validateString(value, "Player name");
                this._name = value;
            }
            addPlaylist(playlist) {
                validate.validateIfUndefined(playlist, 'Player add playlist parameter');
                validate.validateIfObject(playlist, 'Player add playlist parameter');
                validate.validateIfUndefined(playlist.id, 'Player add playlist parameter must have id');
                this._playlists.push(playlist);
                return this;
            }
            getPlaylistById(id) {
                validate.validateIfUndefined(id, 'Player get playlist parameter id');
                validate.validateIfNumber(id, 'Player get playlist parameter id');
                var foundIndex = indexOfElementWithIdInCollection(this._playlists, id);
                if (foundIndex < 0) {
                    return null;
                }
                return this._playlists[foundIndex];
            }
            removePlaylist(id) {
                id = validate.validateId(id);
                var foundIndex = indexOfElementWithIdInCollection(this._playables, id);
                if (foundIndex < 0) {
                    throw new Error(`Playlist with ${id} was now found in list`);
                }
                this._playlists.splice(foundIndex, 1);
                return this;
            }
            listPlaylist(page, size) {
                validate.validatePageAndSize(page, size, this._playlists.length);
                return this
                    ._playlists
                    .slice()
                    .sort(getSortingFunction('name', 'id'))
                    .splice(page * size, size);
            }
            contains(playable, playlist) {
                validate.validateIfUndefined(playable);
                validate.validateIfUndefined(playlist);
                let playableId = validate.validateId(playable.id);
                let playlistId = validate.validaId(playlist.id);

                let playList = this.getPlaylistById(playlistId);
                if (playList === null) {
                    return false;
                }
                let playAble = playList.getPlayableById(playableId);
                if (playAble === null) {
                    return false;
                }
                return true;
            }
            search(pattern) {
                validate.validateString(pattern, 'Search patern');
                return this._playlists
                    .filter(function (playlist) {
                        return playlist
                            .listPlayables()
                            .some(function (playable) {
                                return playable.length !== undefined
                                    && playable
                                        .title
                                        .toLowerCase()
                                        .indexOf(pattern.toLowerCase()) >= 0
                            });
                    })
                    .map(function (playlist) {
                        return {
                            id: playlist.id,
                            name: playlist.name
                        };
                    });
            }
        }

        return {
            getPlayer: (name) => new Player(name),
            getPlayList: (name) => new PlayList(name),
            getAudio: (title, author, length) => new Audio(title, author, length),
            getVideo: (title, author, imdbRating) => new Video(title, author, imdbRating)
        };
    } ());
    return module;
}
let exam = solve();

var player=exam.getPlayer('pesho');
var playlist=exam.getPlayList('gosho');
var audio=exam.getAudio('Ivan','Ivanov',5);
playlist.addPlayable(audio);
player.addPlaylist(playlist);

console.log( player.search('van')); 