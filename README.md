# MovieAssignment
BackEnd development Assignment


Controllers: 
	1. Admin
	2. IMDB

Service Layer:
	1. Admin Service
	2. IMDB Service

Db Layer:
 	this layer should be responsible for all the DB calls.

Authorization Middleware
	This is responsible for authenticating the http requests


Things to implement later: 
Exception handler
Logger
Role based authnetication


AdminController:
	GetAllDetails()
	GetMovieDetailsByID(string id)
	GetMovieDetailsByDate(DateTime date)
	GetReportUsage(DateTime date)
	DeleteMovieDetailsById(string id)

MoviesController:
	Search()
	

Admin Service()

	GetAllDetails()
	GetMovieDetailsByID(string id)
	GetMovieDetailsByDate(DateTime date)
	GetReportUsage(DateTime date)
	DeleteMovieDetailsById(string id)

IMDBService()
	FetchDetailsFromOMDB(string movieName)
	SaveData()

The interfaces are as follows,
IMDBSerivce: iIMDBService : iSourceService
AdminService: iAdminService
