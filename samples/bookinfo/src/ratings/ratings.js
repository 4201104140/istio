var http = require('http')
var dispatcher = require('httpdispatcher')

var port = parseInt(process.argv[2])

var userAddedRatings = [] // used to demonstrate POST functionality

var unavailable = false
var healthy = true

