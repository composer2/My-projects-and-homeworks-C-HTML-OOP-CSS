﻿  try {
  throw {
    message: "An exception object thrown!",
    description: "This is not a good way to throw exceptions!"
  };
} catch (ex) {
  //console.log(ex.name); // 'undefined' because the exception object has no such property!
  console.log(ex.message);
  console.log(ex.description);
}