Imports System
Imports System.Drawing
Imports System.Net.Security
Imports System.Reflection.PortableExecutable

Module Program
    Structure movie
        Dim title As String
        Dim year As Integer
        Dim rate As Integer
        Dim age_rate As String
        Dim length_film As String
        Dim type As String
        Dim year_production As Integer
        Dim location As String
        Dim cast_name As String
    End Structure

    Structure user_profile
        Dim first_name As String
        Dim last_name As String
        Dim age As Integer
        Dim address As String
        Dim phone_number As Integer
        Dim user_name As String
        Dim password As String
        Dim user_movie_list As List(Of movie)
    End Structure



    Sub Main(args As String())



        'creating a list of the structures

        Dim movies As New List(Of movie)
        Dim obj_movie As New movie

        Dim users As New List(Of user_profile)
        Dim obj_user As New user_profile

        'initializing the lists of the movies'

        obj_movie.title = "The Shawshank Redemption"
        obj_movie.year = 1995
        obj_movie.rate = 9.3
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 22 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1994
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = " (Tim Robins, Morgan Freeman, Bob Gunton, William Sadler)"
        movies.Add(obj_movie)


        With obj_movie
            .title = "The Dark Knight"
            .year = 1994
            .rate = 9
            .age_rate = "+16"
            .length_film = "2 hours 32 minutes"
            .type = " Action,Crime,Drama,Thriller"
            .year_production = 1992
            .location = "Chicago,united states"
            .cast_name = "( Heth Ledger, Michel Cane,Bob Gunton)" 
        End With
        movies.Add(obj_movie)

        
        obj_movie.title = "Inception"
        obj_movie.year = 2010
        obj_movie.rate = 8.8
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 40 minutes"
        obj_movie.type = "Action,Adventure,Sci-Fi,Thriller"
        obj_movie.year_production = 2009
        obj_movie.location = "fortress mountain, canada"
        obj_movie.cast_name = "( Leonardo Dicaprio,Michel Cane,Bob Gunton,William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "Interstellar"
        obj_movie.year = 2014
        obj_movie.rate = 8.6
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 49 minutes"
        obj_movie.type = "Adventure,Drama,Sci-Fi"
        obj_movie.year_production = 2013
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Heth Ledger, Michel Cane,Bob Gunton)"
        movies.Add(obj_movie)

        obj_movie.title = "The Shawshank Redemption"
        obj_movie.year = 1995
        obj_movie.rate = 9.3
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 22 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1994
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Leonardo Dicaprio,Michel Cane,Bob Gunton,William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "Joker"
        obj_movie.year = 2019
        obj_movie.rate = 8.2
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 22 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 2018
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = " (Tim Robins, Morgan Freeman, Bob Gunton, William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "Forrest Gump"
        obj_movie.year = 1994
        obj_movie.rate = 9.5
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 21 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1993
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Heth Ledger, Michel Cane,Bob Gunton)"
        movies.Add(obj_movie)

        obj_movie.title = "The Shawshank Redemption"
        obj_movie.year = 1995
        obj_movie.rate = 9.3
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 22 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1994
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = " (Tim Robins, Morgan Freeman, Bob Gunton, William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "Pulp Fiction"
        obj_movie.year = 1992
        obj_movie.rate = 9.1
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 22 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1994
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Heth Ledger, Michel Cane,Bob Gunton)"
        movies.Add(obj_movie)

        obj_movie.title = "The Shawshank Redemption"
        obj_movie.year = 1997
        obj_movie.rate = 9.3
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 22 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1996
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = " (Tim Robins, Morgan Freeman, Bob Gunton, William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "Seven"
        obj_movie.year = 1990
        obj_movie.rate = 9.1
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 2 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1992
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Heth Ledger, Michel Cane,Bob Gunton)"
        movies.Add(obj_movie)

        obj_movie.title = "The Shawshank Redemption"
        obj_movie.year = 1995
        obj_movie.rate = 9.3
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 22 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1994
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = " (Tim Robins, Morgan Freeman, Bob Gunton, William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "The Green Mile"
        obj_movie.year = 1999
        obj_movie.rate = 9.8
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "3 hours 22 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1998
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Leonardo Dicaprio,Michel Cane,Bob Gunton,William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "American History X"
        obj_movie.year = 1992
        obj_movie.rate = 9.1
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 40 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1991
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Heth Ledger, Michel Cane,Bob Gunton)"
        movies.Add(obj_movie)

        obj_movie.title = "Leon"
        obj_movie.year = 1999
        obj_movie.rate = 9.8
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "1 hours 50 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1994
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Leonardo Dicaprio,Michel Cane,Bob Gunton,William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "The Silence of the Lambs"
        obj_movie.year = 1991
        obj_movie.rate = 8.9
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "1 hours 45 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1990
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Leonardo Dicaprio,Michel Cane,Bob Gunton,William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "The Matrix"
        obj_movie.year = 1999
        obj_movie.rate = 8.7
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 16 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 1996
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Heth Ledger, Michel Cane,Bob Gunton)"
        movies.Add(obj_movie)

        obj_movie.title = "The Lord of the Rings"
        obj_movie.year = 2002
        obj_movie.rate = 9.3
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 50 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 2001
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Leonardo Dicaprio,Michel Cane,Bob Gunton,William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "Avatar"
        obj_movie.year = 2012
        obj_movie.rate = 9.5
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 42 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 2008
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Leonardo Dicaprio,Michel Cane,Bob Gunton,William Sadler)"
        movies.Add(obj_movie)

        obj_movie.title = "Avatar"
        obj_movie.year = 2009
        obj_movie.rate = 9.5
        obj_movie.age_rate = "+13"
        obj_movie.length_film = "2 hours 42 minutes"
        obj_movie.type = "Drama"
        obj_movie.year_production = 2008
        obj_movie.location = "1272 smithfield road,united states"
        obj_movie.cast_name = "( Leonardo Dicaprio,Michel Cane,Bob Gunton,William Sadler)"
        movies.Add(obj_movie)


        'initilizing the users list
        obj_user.first_name = "admin"
        obj_user.last_name = "rezei"
        obj_user.age = 60
        obj_user.address = "         "
        obj_user.phone_number = 0
        obj_user.user_name = "adminrezaei"
        obj_user.password = "mypass0"
        obj_user.user_movie_list = obj_movie 
        users.Add(obj_user)

        obj_user.first_name = "david"
        obj_user.last_name = "benit"
        obj_user.age = 20
        obj_user.address = "3045 rue drummond"
        obj_user.phone_number = 51423768
        obj_user.user_name = "davidbenit"
        obj_user.password = "mypass1"
        users.Add(obj_user)

        obj_user.first_name = "william"
        obj_user.last_name = "rank"
        obj_user.age = 22
        obj_user.address = "3045 rue forestier"
        obj_user.phone_number = 51423752
        obj_user.user_name = "williamrank"
        obj_user.password = "mypass2"
        users.Add(obj_user)

        obj_user.first_name = "shery"
        obj_user.last_name = "benit"
        obj_user.age = 50
        obj_user.address = "20 rue river"
        obj_user.phone_number = 645376890
        obj_user.user_name = "sherybenit"
        obj_user.password = "mypass3"
        users.Add(obj_user)


'Testing a new movie into a use's list'
        Dim new_movie As movie
        new_movie.title = "The Shawshank Redemption"
        new_movie.year = 1995
        new_movie.rate = 9.3
        new_movie.age_rate = "+13"
        new_movie.length_film = "2 hours 22 minutes"
        new_movie.type = "Drama"
        new_movie.year_production = 1994
        new_movie.location = "1272 smithfield road,united states"
        new_movie.cast_name = " (Tim Robins, Morgan Freeman, Bob Gunton, William Sadler)"

        Dim current_user As new user_profile
        current_user.first_name = "suzy"
        current_user.last_name = "farim"
        current_user.age = 30
        current_user.address = "45 rue sherbrook"
        current_user.phone_number = 514963012
        current_user.user_name = "suzyfarim"
        current_user.password = "mypass4"
        users.Add(obj_user)

        current_user.user_movie_list.Add(new_movie)


        Console.writeline(users(4).user_movie_list(0).title)





        'creating a list of users username and password



        Dim usernamepass_list As New List(Of String)


        usernamepass_list.Add("adminrezaeimypass0")
        usernamepass_list.Add("davidbenitmypass1")
        usernamepass_list.Add("williamrankmypass2")
        usernamepass_list.Add("sherybenitmypass3")
        usernamepass_list.Add("suzyfarimmypass4")



        'display movie lisst

        Console.WriteLine("   ")
        Console.WriteLine("   ")
        Console.WriteLine("**************************************** Welcome to Movie website ********************************************************************************************************************************************")
        Console.WriteLine("   ")
        Console.WriteLine("movies_title" & vbTab & "       " & "year of release " & vbTab & "       " & "rate" & vbTab & "       " & "age_rate" & vbTab & "       " & "length" & vbTab & "       " & "production_year" & vbTab & "       " & "location" & vbTab & "       " & "cast")
        Console.WriteLine("   ")
        Console.WriteLine("***************************************************************************************************************************************************************************** **********  ")
        For i As Integer = 0 To movies.Count - 1

            Console.WriteLine(movies(i).title & vbTab & "  " & movies(i).year & vbTab & "  " & movies(i).rate & vbTab & movies(i).age_rate & vbTab & movies(i).length_film & vbTab & movies(i).type & vbTab & movies(i).year_production & vbTab & movies(i).location & vbTab & movies(i).cast_name)
            Console.WriteLine("==========================================================================================================================================================================================================")
        Next

        Console.WriteLine("*************************************************************************************************************************************************************************************************************** ")
        Console.WriteLine("   ")
        Console.ReadLine()
        Console.WriteLine("   ")



        Dim ex As Integer = 1
        Dim index_holder As Integer
        Do
            'getting username and password

            Console.WriteLine("   ")
            Console.WriteLine("To access your profilr, you should enter your username and password")
            Console.WriteLine("   ")
            Console.WriteLine("   ")



            Dim ex0 As Integer = 1

            Do
                Dim use_name As String
                Console.WriteLine(" enter your username ")
                use_name = Console.ReadLine()

                Dim pass_name As String
                Console.WriteLine("enter your password")
                pass_name = Console.ReadLine()

                Dim concat_user_pass As String
                concat_user_pass = use_name + pass_name

                Dim no_match As Integer = 0

                For j As Integer = 0 To usernamepass_list.Count - 1

                    If usernamepass_list(j).Equals(concat_user_pass) = True Then

                        index_holder = j
                        ex0 = 0
                        Exit For
                    Else

                        no_match = no_match + 1

                    End If

                Next

                If no_match = usernamepass_list.Count Then
                    Console.WriteLine("wrong username or password, Try again")
                End If

            Loop While ex0 = 1

            Console.WriteLine("   ")
            Console.WriteLine("   ")

            Select Case index_holder

                ' admin option to choose

                Case 0

                    Console.WriteLine("*************************** Welcome Dear Admin  *******************************")
                    Console.WriteLine("           ")
                    Console.WriteLine("           ")


                    Dim ex1 As Integer = 0
                    Do


                        Dim admin_opt As Integer

                        Console.WriteLine("************ Choose from the following options ***********")
                        Console.WriteLine("           ")
                        Console.WriteLine("           ")
                        Console.WriteLine("type 0 if you want to add new user")    'should verify if that user is in the list or not 
                        Console.WriteLine("type 1 if you want to delete a user")   'need password
                        Console.WriteLine("type 2 if you want to add new movie")   'should verify if that movie is in the list or not 
                        Console.WriteLine("type 3 if you want to delete a movie")  'need password
                        Console.WriteLine("type 4 if you want to edit a movie")
                        Console.WriteLine("type 5 if you want to edit a users profile")
                        Console.WriteLine("type 6 if you want to display the movie list")
                        Console.WriteLine("type 7 if you want to display users profile")

                        admin_opt = Console.ReadLine()

                        Select Case admin_opt



                            Case 0                 'add new user if not exist(  password should be uniq)


                                Dim ex10 As Integer = 0
                                Do

                                    ' creating temporary object of the structur to get the information of the new user

                                    Dim obj_temp As New user_profile

                                    Console.WriteLine("enter the first name")
                                    obj_temp.first_name = Console.ReadLine()

                                    Console.WriteLine("enter the last name")
                                    obj_temp.last_name = Console.ReadLine()

                                    Do
                                        Console.WriteLine("enter the phone number")
                                        obj_temp.phone_number = Console.ReadLine()

                                    Loop Until IsNumeric(obj_temp.phone_number)

                                    Do
                                        Console.WriteLine("enter user's age")
                                        obj_temp.age = Console.ReadLine()
                                    Loop Until IsNumeric(obj_temp.age)

                                    Console.WriteLine("enter the address")
                                    obj_temp.address = Console.ReadLine()

                                    Console.WriteLine("enter user name")
                                    obj_temp.user_name = Console.ReadLine()

                                    Console.WriteLine("enter the password")
                                    obj_temp.password = Console.ReadLine()



                                    Dim user_holder(users.Count - 1) As Integer

                                    'check the new user to see if the pass  is the same so do not allow to add

                                    For j As Integer = 0 To users.Count - 1

                                        If users(j).password = obj_temp.password Then

                                            Console.WriteLine("the password is exist choose different one")
                                            ex10 = 1
                                            Exit For



                                        End If
                                        'user_holder(j) = 1

                                    Next


                                    Dim concatuserpass As String
                                    users.Add(obj_temp)

                                    concatuserpass = obj_temp.user_name + obj_temp.password
                                    usernamepass_list.Add(concatuserpass)





                                    ex1 = 1
                                    Console.WriteLine("type 1 if you want to add the new user if not 0")
                                    ex10 = Console.ReadLine()

                                Loop While ex10 = 1





                            Case 1              'delete existing user



                                Dim ex7 As Integer = 0
                                Do
                                    Dim pass As String
                                    Dim delete_user As String
                                    Console.WriteLine("type the username of the user you want to delete")
                                    delete_user = Console.ReadLine()


                                    Dim ex8 As Integer = 0
                                    Dim count_use(users.Count - 1) As Integer
                                    Dim valid As String


                                    For j As Integer = 0 To users.Count - 1
                                        If users(j).user_name = delete_user Then

                                            Console.WriteLine("type the password of the user that you want to delete")
                                            pass = Console.ReadLine

                                            If users(j).password = pass Then

                                                Do
                                                    Console.WriteLine("enter your password")
                                                    valid = Console.ReadLine()
                                                    If valid = users(0).password Then
                                                        users.RemoveAt(j)

                                                        usernamepass_list.RemoveAt(j)

                                                        Exit For
                                                    Else
                                                        Console.WriteLine("not a valid password,try again")
                                                        ex8 = 1
                                                    End If
                                                Loop While ex8 = 1

                                            Else
                                                count_use(j) = 0

                                            End If

                                        Else
                                            count_use(j) = 0
                                        End If
                                    Next

                                    Dim z_num As Integer
                                    For i As Integer = 0 To count_use.Length - 1
                                        If count_use(i) = 1 Then
                                            Exit For
                                        Else
                                            z_num = z_num + 1

                                        End If
                                    Next




                                    If z_num = users.Count Then
                                        Console.WriteLine("no match found,try again")

                                    End If






                                    Console.WriteLine("do you wish to continue deleting? if yes type 1 else 0")
                                    ex7 = Console.ReadLine()





                                Loop While ex7 = 1






                            Case 2               'add a new movie if not exist



                                Dim ex9 As Integer = 0
                                Do


                                    ' creating temporary object of the structur to get the information of the new film

                                    Dim obj_temp As New movie
                                    Dim mach As Integer = 0


                                    Console.WriteLine("enter the title")
                                    obj_temp.title = Console.ReadLine()


                                    Do
                                        Console.WriteLine("enter the releas year")
                                        obj_temp.year = Console.ReadLine()

                                    Loop Until IsNumeric(obj_movie.year)


                                    For j As Integer = 0 To movies.Count - 1

                                        If movies(j).title = obj_temp.title Then
                                            If movies(j).year = obj_temp.year Then


                                                Console.WriteLine("this movie is in the list")
                                                mach = 1
                                                Console.WriteLine("type 1 if you want to add the new movie if not 0")
                                                ex9 = Console.ReadLine()
                                                Exit For

                                            Else
                                                mach = 0
                                                Exit For



                                            End If




                                        End If

                                    Next






                                    If mach = 0 Then

                                        Do
                                            Console.WriteLine("enter the movies rate")
                                            obj_temp.rate = Console.ReadLine()
                                        Loop Until IsNumeric(obj_movie.rate)


                                        Console.WriteLine("enter the age rate")
                                        obj_temp.age_rate = Console.ReadLine()


                                        Console.WriteLine("enter the length of the film")
                                        obj_temp.length_film = Console.ReadLine()

                                        Console.WriteLine("enter movies genre")
                                        obj_temp.type = Console.ReadLine()

                                        Do
                                            Console.WriteLine("enter the movies production year")
                                            obj_temp.year_production = Console.ReadLine()
                                        Loop Until IsNumeric(obj_movie.year_production)

                                        Console.WriteLine("enter movies location")
                                        obj_temp.location = Console.ReadLine()

                                        Console.WriteLine("enter casts and crew")
                                        obj_temp.cast_name = Console.ReadLine()

                                        Dim movie_holder(movies.Count - 1) As Integer

                                        'check the new movie to see if the title and year is the same so do not allow to add


                                        movies.Add(obj_temp)



                                        Console.WriteLine("type 1 if you want to add the new movie if not 0")
                                        ex9 = Console.ReadLine()





                                    End If





                                Loop While ex9 = 1




                            Case 3              'delete a movie if exist



                                Dim ex5 As Integer = 0
                                Do

                                    Dim z_num As Integer = 0
                                    Dim yeard As Integer
                                    Dim delete_movie As String
                                    Console.WriteLine("type the name of the movie you want to delete")
                                    delete_movie = Console.ReadLine()



                                    Dim ex6 As Integer = 0
                                    Dim count_movie(movies.Count - 1) As Integer
                                    Dim valid As String
                                    For j As Integer = 0 To movies.Count - 1
                                        If movies(j).title = delete_movie Then

                                            Console.WriteLine("type the year of the movie that you want to delete")
                                            yeard = Console.ReadLine

                                            If movies(j).year = yeard Then

                                                Do
                                                    Console.WriteLine("enter your password")
                                                    valid = Console.ReadLine()
                                                    If valid = users(0).password Then
                                                        movies.RemoveAt(j)

                                                        Exit For
                                                    Else
                                                        Console.WriteLine("not a valid password,try again")
                                                        ex6 = 1
                                                    End If
                                                Loop While ex6 = 1
                                            Else
                                                count_movie(j) = 0

                                            End If


                                        Else
                                            count_movie(j) = 0
                                        End If
                                    Next


                                    For i As Integer = 0 To count_movie.Length - 1
                                        If count_movie(i) = 0 Then

                                            z_num = z_num + 1


                                        End If
                                    Next




                                    If z_num = movies.Count Then
                                        Console.WriteLine("no match found,try again")

                                    End If



                                    Console.WriteLine("do you wish to continue deleting? if yes type 1 else 0")
                                    ex5 = Console.ReadLine()



                                Loop While ex5 = 1








                            Case 4            'edit an existing movies parameter



                                Dim z_hold As Integer

                                Dim ex_1 As Integer = 0
                                Do


                                    Dim ex_o As Integer = 0
                                    Do


                                        Dim tit_movie As String
                                        Console.WriteLine("type the title of the movie you want to edit")
                                        tit_movie = Console.ReadLine()


                                        Dim z_array(movies.Count) As Integer
                                        Dim z1_array(movies.Count) As Integer

                                        For i As Integer = 0 To movies.Count - 1

                                            If movies(i).title = tit_movie Then



                                                Dim y_movie As Integer
                                                Console.WriteLine("type the release year of the movie you want to edit")
                                                y_movie = Console.ReadLine()

                                                If movies(i).year = y_movie Then
                                                    z_hold = i
                                                    ex_o = 0
                                                    Exit For

                                                Else
                                                    Console.WriteLine("no match found for the movie's year, try again")
                                                    ex_o = 1
                                                End If

                                            ElseIf movies(i).title <> tit_movie Then
                                                z_array(i) = 1

                                            End If


                                        Next






                                        Dim v1 As Integer = 0
                                        For h1 As Integer = 0 To movies.Count - 1
                                            If z_array(h1) = 1 Then
                                                v1 = v1 + 1
                                            Else
                                                Exit For
                                            End If
                                        Next

                                        If v1 = movies.Count Then
                                            Console.WriteLine("no match found for the entered movie's title, try again")
                                            ex_o = 1
                                        End If





                                    Loop While ex_o = 1


                                    Dim temp_1 As New List(Of movie)
                                    Dim obj_temp_1 As New movie

                                    Dim title_1 As String
                                    Dim year_1 As Integer
                                    Dim rate_1 As Integer
                                    Dim age_rate_1 As String
                                    Dim length_film_1 As String
                                    Dim type_1 As String
                                    Dim year_production_1 As Integer
                                    Dim location_1 As String
                                    Dim cast_name_1 As String

                                    For j As Integer = 0 To 8

                                        Select Case j
                                            Case 0
                                                Dim ans_0 As String
                                                Console.WriteLine("do you want to edit the title? if yes type yes else no")
                                                ans_0 = Console.ReadLine()

                                                If ans_0 = "yes" Then


                                                    Console.WriteLine("enter the new title")
                                                    title_1 = Console.ReadLine
                                                    obj_temp_1.title = title_1
                                                Else

                                                    obj_temp_1.title = movies(z_hold).title
                                                    Exit Select

                                                End If


                                            Case 1

                                                Dim ans_1 As String
                                                Console.WriteLine("do you want to edit the release year? if yes type yes else no")
                                                ans_1 = Console.ReadLine()

                                                If ans_1 = "yes" Then


                                                    Console.WriteLine("enter the released year")
                                                    year_1 = Console.ReadLine
                                                    obj_temp_1.year = year_1
                                                Else

                                                    obj_temp_1.year = movies(z_hold).year
                                                    Exit Select

                                                End If



                                            Case 2


                                                Dim ans_2 As String
                                                Console.WriteLine("do you want to edit the rate? if yes type yes else no")
                                                ans_2 = Console.ReadLine()

                                                If ans_2 = "yes" Then


                                                    Console.WriteLine("enter the new rate")
                                                    rate_1 = Console.ReadLine
                                                    obj_temp_1.rate = rate_1
                                                Else
                                                    obj_temp_1.rate = movies(z_hold).rate
                                                    Exit Select

                                                End If



                                            Case 3

                                                Dim ans_3 As String
                                                Console.WriteLine("do you want to edit the age rate? if yes type yes else no")
                                                ans_3 = Console.ReadLine()

                                                If ans_3 = "yes" Then


                                                    Console.WriteLine("enter the new age")
                                                    age_rate_1 = Console.ReadLine
                                                    obj_temp_1.age_rate = age_rate_1
                                                Else
                                                    obj_temp_1.age_rate = movies(z_hold).age_rate
                                                    Exit Select

                                                End If



                                            Case 4

                                                Dim ans_4 As String
                                                Console.WriteLine("do you want to edit the length? if yes type yes else no")
                                                ans_4 = Console.ReadLine()

                                                If ans_4 = "yes" Then


                                                    Console.WriteLine("enter the new length")
                                                    length_film_1 = Console.ReadLine
                                                    obj_temp_1.length_film = length_film_1
                                                Else
                                                    obj_temp_1.length_film = movies(z_hold).length_film
                                                    Exit Select

                                                End If


                                            Case 5

                                                Dim ans_5 As String
                                                Console.WriteLine("do you want to edit the type? if yes type yes else no")
                                                ans_5 = Console.ReadLine()

                                                If ans_5 = "yes" Then


                                                    Console.WriteLine("enter the new type")
                                                    type_1 = Console.ReadLine
                                                    obj_temp_1.type = type_1
                                                Else
                                                    obj_temp_1.type = movies(z_hold).type
                                                    Exit Select

                                                End If



                                            Case 6

                                                Dim ans_6 As String
                                                Console.WriteLine("do you want to edit the production year? if yes type yes else no")
                                                ans_6 = Console.ReadLine()

                                                If ans_6 = "yes" Then


                                                    Console.WriteLine("enter the production year")
                                                    year_production_1 = Console.ReadLine
                                                    obj_temp_1.year_production = year_production_1
                                                Else

                                                    obj_temp_1.year_production = movies(z_hold).year_production
                                                    Exit Select

                                                End If


                                            Case 7

                                                Dim ans_7 As String
                                                Console.WriteLine("do you want to edit the location? if yes type yes else no")
                                                ans_7 = Console.ReadLine()

                                                If ans_7 = "yes" Then


                                                    Console.WriteLine("enter the new location")
                                                    location_1 = Console.ReadLine
                                                    obj_temp_1.location = location_1
                                                Else

                                                    obj_temp_1.location = movies(z_hold).location
                                                    Exit Select

                                                End If


                                            Case 8

                                                Dim ans_8 As String
                                                Console.WriteLine("do you want to edit cast's name? if yes type yes else no")
                                                ans_8 = Console.ReadLine()

                                                If ans_8 = "yes" Then


                                                    Console.WriteLine("enter the new cast's name")
                                                    cast_name_1 = Console.ReadLine
                                                    obj_temp_1.cast_name = cast_name_1
                                                Else

                                                    obj_temp_1.cast_name = movies(z_hold).cast_name
                                                    Exit Select

                                                End If





                                        End Select


                                    Next

                                    temp_1.Add(obj_temp_1)




                                    If temp_1(0).title <> movies(z_hold).title Then
                                        movies(z_hold) = temp_1(0)
                                    ElseIf temp_1(0).year <> movies(z_hold).year Then
                                        movies(z_hold) = temp_1(0)
                                    ElseIf temp_1(0).rate <> movies(z_hold).rate Then
                                        movies(z_hold) = temp_1(0)
                                    ElseIf temp_1(0).age_rate <> movies(z_hold).age_rate Then
                                        movies(z_hold) = temp_1(0)
                                    ElseIf temp_1(0).length_film <> movies(z_hold).length_film Then
                                        movies(z_hold) = temp_1(0)
                                    ElseIf temp_1(0).type <> movies(z_hold).type Then
                                        movies(z_hold) = temp_1(0)

                                    ElseIf temp_1(0).year_production <> movies(z_hold).year_production Then
                                        movies(z_hold) = temp_1(0)
                                    ElseIf temp_1(0).location <> movies(z_hold).location Then
                                        movies(z_hold) = temp_1(0)
                                    ElseIf temp_1(0).cast_name <> movies(z_hold).cast_name Then

                                        movies(z_hold) = temp_1(0)

                                    End If




                                    Console.WriteLine("type 1 if you want to edit another movie else 0")
                                    ex_1 = Console.ReadLine()


                                Loop While ex_1 = 1






                            Case 5             'edit an existing users profile

                                Dim ex_0 As Integer = 0
                                Do
                                    Dim ind As Integer

                                    Dim ex_i As Integer = 0
                                    Do

                                        Dim ze_array(users.Count - 1) As Integer
                                        Dim pass_holder As String
                                        Console.WriteLine("enter the password of the user ,you want to edit ")
                                        pass_holder = Console.ReadLine()


                                        For i As Integer = 0 To users.Count - 1
                                            If users(i).password = pass_holder Then
                                                ind = i

                                                Exit For


                                            Else
                                                ze_array(i) = 1

                                            End If

                                        Next

                                        Dim v As Integer
                                        For h As Integer = 0 To users.Count - 1
                                            If ze_array(h) = 1 Then
                                                v = v + 1

                                            End If
                                        Next

                                        If v = users.Count Then
                                            Console.WriteLine("no match found for the entered password, try again")
                                            ex_i = 1
                                        End If


                                    Loop While ex_i = 1







                                    Dim temp0 As New user_profile

                                    Dim temp1 As New List(Of user_profile)
                                    Dim obj_temp1 As New user_profile


                                    temp0 = users(ind)


                                    Dim fname As String
                                    Dim lname As String
                                    Dim ag As Integer
                                    Dim ph As Integer
                                    Dim addr As String
                                    Dim usen As String
                                    Dim passn As String
                                    For i = 0 To 6

                                        Select Case i
                                            Case 0
                                                Dim ans0 As String
                                                Console.WriteLine("do you want to edit the first name? if yes type yes else no")
                                                ans0 = Console.ReadLine()

                                                If ans0 = "yes" Then


                                                    Console.WriteLine("enter the new name")
                                                    fname = Console.ReadLine
                                                    obj_temp1.first_name = fname
                                                Else

                                                    obj_temp1.first_name = users(ind).first_name
                                                    Exit Select

                                                End If


                                            Case 1

                                                Dim ans1 As String
                                                Console.WriteLine("do you want to edit the last name? if yes type yes else no")
                                                ans1 = Console.ReadLine()

                                                If ans1 = "yes" Then


                                                    Console.WriteLine("enter the new name")
                                                    lname = Console.ReadLine
                                                    obj_temp1.last_name = lname
                                                Else

                                                    obj_temp1.last_name = users(ind).last_name
                                                    Exit Select

                                                End If


                                            Case 2

                                                Dim ans2 As String
                                                Console.WriteLine("do you want to edit the age? if yes type yes else no")
                                                ans2 = Console.ReadLine()

                                                If ans2 = "yes" Then


                                                    Console.WriteLine("enter the new age")
                                                    ag = Console.ReadLine
                                                    obj_temp1.age = ag
                                                Else
                                                    obj_temp1.age = users(ind).age
                                                    Exit Select

                                                End If


                                            Case 3
                                                Dim ans3 As String
                                                Console.WriteLine("do you want to edit the phone number? if yes type yes else no")
                                                ans3 = Console.ReadLine()

                                                If ans3 = "yes" Then


                                                    Console.WriteLine("enter the new phone number")
                                                    ph = Console.ReadLine
                                                    obj_temp1.phone_number = ph
                                                Else
                                                    obj_temp1.phone_number = users(ind).phone_number
                                                    Exit Select

                                                End If


                                            Case 4

                                                Dim ans4 As String
                                                Console.WriteLine("do you want to edit address? if yes type yes else no")
                                                ans4 = Console.ReadLine()

                                                If ans4 = "yes" Then


                                                    Console.WriteLine("enter the new address")
                                                    addr = Console.ReadLine
                                                    obj_temp1.address = addr
                                                Else

                                                    obj_temp1.address = users(ind).address
                                                    Exit Select

                                                End If


                                            Case 5

                                                Dim ans5 As String
                                                Console.WriteLine("do you want to edit username? if yes type yes else no")
                                                ans5 = Console.ReadLine()

                                                If ans5 = "yes" Then


                                                    Console.WriteLine("enter the new username")
                                                    usen = Console.ReadLine
                                                    obj_temp1.user_name = usen
                                                Else

                                                    obj_temp1.user_name = users(ind).user_name
                                                    Exit Select

                                                End If


                                            Case 6

                                                Dim ans6 As String
                                                Console.WriteLine("do you want to edit password? if yes type yes else no")
                                                ans6 = Console.ReadLine()

                                                If ans6 = "yes" Then


                                                    Console.WriteLine("enter the new password")
                                                    passn = Console.ReadLine
                                                    obj_temp1.password = passn
                                                Else

                                                    obj_temp1.password = users(ind).password
                                                    Exit Select

                                                End If


                                        End Select



                                    Next

                                    temp1.Add(obj_temp1)


                                    Dim conuserpass As String

                                    If temp1(0).first_name <> users(ind).first_name Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).last_name <> users(ind).last_name Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).age <> users(ind).age Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).address <> users(ind).address Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).phone_number <> users(ind).phone_number Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).user_name <> users(ind).user_name Then
                                        users(ind) = temp1(0)

                                    ElseIf temp1(0).password <> users(ind).password Then
                                        users(ind) = temp1(0)

                                    End If


                                    conuserpass = users(ind).user_name + users(ind).password

                                    If usernamepass_list(ind) <> conuserpass Then
                                        usernamepass_list(ind) = conuserpass

                                    End If





                                    Console.WriteLine("type 1 if you want to edit another user else 0")
                                    ex_0 = Console.ReadLine()
                                Loop While ex_0 = 1







                            Case 6              'display the list of the movies

                                Console.WriteLine("   ")
                                Console.WriteLine("   ")
                                Console.WriteLine("**************************************** Welcome To Movie website ********************************************************************************************************************************************")
                                Console.WriteLine("   ")
                                Console.WriteLine("movies_title" & vbTab & "       " & "year Of release " & vbTab & "       " & "rate" & vbTab & "       " & "age_rate" & vbTab & "       " & "length" & vbTab & "       " & "production_year" & vbTab & "       " & "location" & vbTab & "       " & "cast")
                                Console.WriteLine("   ")
                                Console.WriteLine("***************************************************************************************************************************************************************************** **********  ")
                                For i As Integer = 0 To movies.Count - 1

                                    Console.WriteLine(movies(i).title & vbTab & "  " & movies(i).year & vbTab & "  " & movies(i).rate & vbTab & movies(i).age_rate & vbTab & movies(i).length_film & vbTab & movies(i).type & vbTab & movies(i).year_production & vbTab & movies(i).location & vbTab & movies(i).cast_name)
                                    Console.WriteLine("==========================================================================================================================================================================================================")
                                Next

                                Console.WriteLine("*************************************************************************************************************************************************************************************************************** ")
                                Console.WriteLine("   ")
                                Console.ReadLine()
                                Console.WriteLine("   ")






                            Case 7             'display of the users first name and last name


                                Console.WriteLine("   ")
                                Console.WriteLine("   ")
                                Console.WriteLine("**************************************** Welcome To user's list ********************************************************************************************************************************************")
                                Console.WriteLine("   ")
                                Console.WriteLine("user's first_name" & vbTab & "       " & "user's last_name ")
                                Console.WriteLine("   ")
                                Console.WriteLine("***************************************************************************************************************************************************************************** **********  ")
                                For i As Integer = 1 To users.Count - 1

                                    Console.WriteLine(users(i).first_name & vbTab & users(i).last_name)
                                    Console.WriteLine("==========================================================================================================================================================================================================")
                                Next

                                Console.WriteLine("*************************************************************************************************************************************************************************************************************** ")
                                Console.WriteLine("   ")
                                Console.ReadLine()
                                Console.WriteLine("   ")






                            Case Else
                                Console.WriteLine("invalid entry, try again")
                                ex1 = 1

                        End Select

                    Loop While ex1 = 1




                    ' user menu options to choose

                Case Else

                    Console.WriteLine("********************** Welcome Dear user  ****************************")
                    Console.WriteLine("           ")
                    Console.WriteLine("           ")


                    Dim ex2 As Integer = 0
                    Do


                        Dim user_opt As Integer
                        Console.WriteLine("*********** Choose from the following options ***********")
                        Console.WriteLine("           ")
                        Console.WriteLine("           ")
                        Console.WriteLine("type 0 if you want to add new movie")        'should verify if that movie is in the list or not 
                        Console.WriteLine("type 1 if you want to edit your profile")
                        Console.WriteLine("type 2 if you want to delete your profile")  'need password
                        Console.WriteLine("type 3 if you want to see the movie list")

                        user_opt = Console.ReadLine()


                        Select Case user_opt

                            Case 0               'add new movie


                                Dim ex9 As Integer = 0
                                Do


                                    ' creating temporary object of the structur to get the information of the new film

                                    Dim obj_temp As New movie
                                    Dim mach As Integer = 0


                                    Console.WriteLine("enter the title")
                                        obj_temp.title = Console.ReadLine()


                                        Do
                                            Console.WriteLine("enter the releas year")
                                            obj_temp.year = Console.ReadLine()

                                        Loop Until IsNumeric(obj_movie.year)


                                    For j As Integer = 0 To movies.Count - 1

                                        If movies(j).title = obj_temp.title Then
                                            If movies(j).year = obj_temp.year Then


                                                Console.WriteLine("this movie is in the list")
                                                mach = 1
                                                Console.WriteLine("type 1 if you want to add the new movie if not 0")
                                                ex9 = Console.ReadLine()
                                                Exit For

                                            Else
                                                mach = 0
                                                Exit For



                                            End If




                                        End If

                                    Next






                                    If mach = 0 Then

                                        Do
                                            Console.WriteLine("enter the movies rate")
                                            obj_temp.rate = Console.ReadLine()
                                        Loop Until IsNumeric(obj_movie.rate)


                                        Console.WriteLine("enter the age rate")
                                        obj_temp.age_rate = Console.ReadLine()


                                        Console.WriteLine("enter the length of the film")
                                        obj_temp.length_film = Console.ReadLine()

                                        Console.WriteLine("enter movies genre")
                                        obj_temp.type = Console.ReadLine()

                                        Do
                                            Console.WriteLine("enter the movies production year")
                                            obj_temp.year_production = Console.ReadLine()
                                        Loop Until IsNumeric(obj_movie.year_production)

                                        Console.WriteLine("enter movies location")
                                        obj_temp.location = Console.ReadLine()

                                        Console.WriteLine("enter casts and crew")
                                        obj_temp.cast_name = Console.ReadLine()

                                        Dim movie_holder(movies.Count - 1) As Integer

                                        'check the new movie to see if the title and year is the same so do not allow to add


                                        movies.Add(obj_temp)



                                        Console.WriteLine("type 1 if you want to add the new movie if not 0")
                                        ex9 = Console.ReadLine()





                                    End If





                                Loop While ex9 = 1





                            Case 1                 'edit the profile







                                Dim ex_0 As Integer = 0
                                Do
                                    Dim ze_array(users.Count - 1) As Integer
                                    Dim pass_holder As String
                                    Console.WriteLine("enter your password ")
                                    pass_holder = Console.ReadLine()

                                    Dim ind As Integer
                                    For i As Integer = 0 To users.Count - 1
                                        If users(i).password = pass_holder Then
                                            ind = i

                                            Exit For


                                        Else
                                            ze_array(i) = 0

                                        End If

                                    Next

                                    Dim v As Integer
                                    For h As Integer = 0 To users.Count - 1
                                        If ze_array(h) = 0 Then
                                            v = +1

                                        End If
                                    Next

                                    If v = users.Count Then
                                        Console.WriteLine("no match found for the entered password, try again")
                                        ex_0 = 1
                                    End If




                                    Dim temp0 As New user_profile

                                    Dim temp1 As New List(Of user_profile)
                                    Dim obj_temp1 As New user_profile


                                    temp0 = users(ind)


                                    Dim fname As String
                                    Dim lname As String
                                    Dim ag As Integer
                                    Dim ph As Integer
                                    Dim addr As String
                                    Dim usen As String
                                    Dim passn As String
                                    For i = 0 To 6

                                        Select Case i
                                            Case 0
                                                Dim ans0 As String
                                                Console.WriteLine("do you want to edit the first name? if yes type yes else no")
                                                ans0 = Console.ReadLine()

                                                If ans0 = "yes" Then


                                                    Console.WriteLine("enter the new name")
                                                    fname = Console.ReadLine
                                                    obj_temp1.first_name = fname
                                                Else

                                                    obj_temp1.first_name = users(ind).first_name
                                                    Exit Select

                                                End If


                                            Case 1

                                                Dim ans1 As String
                                                Console.WriteLine("do you want to edit the last name? if yes type yes else no")
                                                ans1 = Console.ReadLine()

                                                If ans1 = "yes" Then


                                                    Console.WriteLine("enter the new name")
                                                    lname = Console.ReadLine
                                                    obj_temp1.last_name = lname
                                                Else

                                                    obj_temp1.last_name = users(ind).last_name
                                                    Exit Select

                                                End If


                                            Case 2

                                                Dim ans2 As String
                                                Console.WriteLine("do you want to edit the age? if yes type yes else no")
                                                ans2 = Console.ReadLine()

                                                If ans2 = "yes" Then


                                                    Console.WriteLine("enter the new age")
                                                    ag = Console.ReadLine
                                                    obj_temp1.age = ag
                                                Else
                                                    obj_temp1.age = users(ind).age
                                                    Exit Select

                                                End If


                                            Case 3
                                                Dim ans3 As String
                                                Console.WriteLine("do you want to edit the phone number? if yes type yes else no")
                                                ans3 = Console.ReadLine()

                                                If ans3 = "yes" Then


                                                    Console.WriteLine("enter the new phone number")
                                                    ph = Console.ReadLine
                                                    obj_temp1.phone_number = ph
                                                Else
                                                    obj_temp1.phone_number = users(ind).phone_number
                                                    Exit Select

                                                End If


                                            Case 4

                                                Dim ans4 As String
                                                Console.WriteLine("do you want to edit address? if yes type yes else no")
                                                ans4 = Console.ReadLine()

                                                If ans4 = "yes" Then


                                                    Console.WriteLine("enter the new address")
                                                    addr = Console.ReadLine
                                                    obj_temp1.address = addr
                                                Else

                                                    obj_temp1.address = users(ind).address
                                                    Exit Select

                                                End If


                                            Case 5

                                                Dim ans5 As String
                                                Console.WriteLine("do you want to edit username? if yes type yes else no")
                                                ans5 = Console.ReadLine()

                                                If ans5 = "yes" Then


                                                    Console.WriteLine("enter the new username")
                                                    usen = Console.ReadLine
                                                    obj_temp1.user_name = usen
                                                Else

                                                    obj_temp1.user_name = users(ind).user_name
                                                    Exit Select

                                                End If


                                            Case 6

                                                Dim ans6 As String
                                                Console.WriteLine("do you want to edit password? if yes type yes else no")
                                                ans6 = Console.ReadLine()

                                                If ans6 = "yes" Then


                                                    Console.WriteLine("enter the new password")
                                                    passn = Console.ReadLine
                                                    obj_temp1.password = passn
                                                Else

                                                    obj_temp1.password = users(ind).password
                                                    Exit Select

                                                End If


                                        End Select



                                    Next

                                    temp1.Add(obj_temp1)

                                    Dim conuserpass As String

                                    If temp1(0).first_name <> users(ind).first_name Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).last_name <> users(ind).last_name Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).age <> users(ind).age Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).address <> users(ind).address Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).phone_number <> users(ind).phone_number Then
                                        users(ind) = temp1(0)
                                    ElseIf temp1(0).user_name <> users(ind).user_name Then
                                        users(ind) = temp1(0)

                                    ElseIf temp1(0).password <> users(ind).password Then
                                        users(ind) = temp1(0)

                                    End If


                                    conuserpass = users(ind).user_name + users(ind).password

                                    If usernamepass_list(ind) <> conuserpass Then
                                        usernamepass_list(ind) = conuserpass

                                    End If





                                    Console.WriteLine("type 1 if you want to edit your profile again")
                                    ex_0 = Console.ReadLine()
                                Loop While ex_0 = 1




                            Case 2               'delete the profile( needs password)

                                Dim ex4 As Integer = 0
                                Do


                                    Dim sure As String
                                    Console.WriteLine("if you want to delete your profile ,you should enter your password")
                                    sure = Console.ReadLine()

                                    Dim m As Integer = 0
                                    Dim n As Integer
                                    For i As Integer = 0 To users.Count - 1

                                        If users(i).password.Equals(sure) = True Then

                                            n = i

                                            Exit For

                                        Else
                                            m = m + 1

                                        End If




                                    Next

                                    If m = users.Count Then


                                        Console.WriteLine("your password is wrong,try again")
                                        ex4 = 1

                                    Else


                                        users.RemoveAt(n)
                                        usernamepass_list.RemoveAt(n)
                                        ex4 = 0

                                    End If
                                    Console.WriteLine("your accont is permanently deleted")






                                Loop While ex4 = 1





                            Case 3                   'display the move list

                                Console.WriteLine("   ")
                                Console.WriteLine("   ")
                                Console.WriteLine("**************************************** Welcome to Movie website ********************************************************************************************************************************************")
                                Console.WriteLine("   ")
                                Console.WriteLine("No." & vbTab & "       " & "movies_title" & vbTab & "       " & "year of release " & vbTab & "       " & "rate" & vbTab & "       " & "age_rate" & vbTab & "       " & "length" & vbTab & "       " & "production_year" & vbTab & "       " & "location" & vbTab & "       " & "cast")
                                Console.WriteLine("   ")
                                Console.WriteLine("***************************************************************************************************************************************************************************** **********  ")
                                For i As Integer = 0 To movies.Count - 1

                                    Console.WriteLine(movies(i).title & vbTab & "  " & movies(i).year & vbTab & "  " & movies(i).rate & vbTab & movies(i).age_rate & vbTab & movies(i).length_film & vbTab & movies(i).type & vbTab & movies(i).year_production & vbTab & movies(i).location & vbTab & movies(i).cast_name)
                                    Console.WriteLine("==========================================================================================================================================================================================================")
                                Next

                                Console.WriteLine("*************************************************************************************************************************************************************************************************************** ")
                                Console.WriteLine("   ")
                                Console.ReadLine()
                                Console.WriteLine("   ")





                            Case Else

                                Console.WriteLine("invalid entry, try again")
                                ex2 = 1

                        End Select

                    Loop While ex2 = 1









            End Select






        Loop While ex = 1


    End Sub
End Module
