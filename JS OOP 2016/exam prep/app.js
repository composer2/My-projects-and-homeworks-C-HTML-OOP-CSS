var bob = {
  _name: "Bob",
  _friends: ["Tozi","Onzi","Onezi"],
  printFriends() {
    this._friends.forEach(f =>
      console.log(this._name + " knows " + f));
  }
}
console.log(bob.printFriends());