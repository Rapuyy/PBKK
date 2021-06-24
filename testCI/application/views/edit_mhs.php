<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Laravel</title>

        <!-- Fonts -->
        <link href="https://fonts.googleapis.com/css?family=Nunito:200,600" rel="stylesheet">

        <!-- Styles -->
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
        <style>
            html, body {
                background-color: #fff;
                color: #636b6f;
                font-family: 'Nunito', sans-serif;
                font-weight: 200;
                height: 100vh;
                margin: 0;
            }

            .full-height {
                height: 100vh;
            }

            .flex-center {
                align-items: center;
                display: flex;
                justify-content: center;
            }

            .position-ref {
                position: relative;
            }

            .top-right {
                position: absolute;
                right: 10px;
                top: 18px;
            }

            .content {
                text-align: center;
            }

            .title {
                font-size: 84px;
            }

            .links > a {
                color: #636b6f;
                padding: 0 25px;
                font-size: 13px;
                font-weight: 600;
                letter-spacing: .1rem;
                text-decoration: none;
                text-transform: uppercase;
            }

            .m-b-md {
                margin-bottom: 30px;
            }
        </style>
    </head>
    <body>
        <div class="flex-center position-ref full-height">
            <div class="content">
                <div class="title m-b-md">
                    Edit Mahasiswa
                </div>
                <div>
                    <form action="" method="POST" class="form" enctype="multipart/form-data">
                        <input type="hidden" name="id" value="<?php echo $mhs->id ?>">
                        <div class="form-group">
                            <h5>Nama</h5>
                            <input type="text" name="nama" class="form-control" value="<?php echo $mhs->nama ?>">
                            <h5>NRP</h5>
                            <input type="text" name="nrp" class="form-control" value="<?php echo $mhs->nrp ?>">
                            <h5>Alamat</h5>
                            <input type="text" name="alamat" class="form-control" value="<?php echo $mhs->alamat ?>">
                            <h5>No HP</h5>
                            <input type="text" name="nohp" class="form-control" value="<?php echo $mhs->nohp ?>">
                            <h5>Jurusan</h5>
                            <input type="text" name="jurusan" class="form-control" value="<?php echo $mhs->jurusan ?>">
                        </div>
                        <button class="btn-primary">Edit</button>
                    </form>
                </div>
            </div>
        </div>
    </body>
</html>
