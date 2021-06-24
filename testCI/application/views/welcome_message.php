<?php $this->load->helper('url'); ?>

<html lang="en">
    <head>
        <!-- <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, user-scalable=no"> -->
        <title>title</title>
        <link rel="stylesheet" type="text/css" href="<?php echo base_url(); ?>public/style.css">
        <script type = "text/javascript">
            function displayNextImage() {
                x = (x === images.length - 1) ? 0 : x + 1;
                document.getElementById("profpic").src = images[x];
            }
  
            function startTimer() {
                setInterval(displayNextImage, 2000);
            }
  
            var images = [], x = -1;
            images[0] = "<?php echo base_url(); ?>public/img/poto1.jpg";
            images[1] = "<?php echo base_url(); ?>public/img/poto2.jpg";
			console.log(images[0]);
        </script>
    </head>
    <body class="container" onload="startTimer()">
        <!-- bagian kiri -->
        <div class="grid-1">
            <div class="tulisan-kiri">
                <div>
                    <img id="profpic" src="<?php echo base_url(); ?>public/img/poto1.jpg" alt="foto">
                    <h3>Muhammad Rafi Yudhistira</h3>
                    <p id="status">Mahasiswa Informatika ITS</p>
                    <div class="biodata">
                        <div class="grid-1">
                            <img class="icon" src="<?php echo base_url(); ?>public/img/loc.png" alt="location">
                            <img class="icon" src="<?php echo base_url(); ?>public/img/telpon.png" alt="telpon">
                            <img class="icon" src="<?php echo base_url(); ?>public/img/email.png" alt="email">
                        </div>
                        <div class="grid-2">
                            <p style="line-height: 20px;">Jakarta Selatan, Indonesia</p>
                            <p style="line-height: 50px;">081290815400</p>
                            <p>raffyuu@gmail.com</p>
                        </div>
                    </div>
                </div>
                <div>
                    <h3>Traits</h3>
                    <img src="<?php echo base_url(); ?>public/img/trait.png" alt="trait">
                </div>
            </div>
            
        </div>
        <!-- bagian kanan -->
        <div class="grid-2">
            <div class="tulisan-kanan">
                <div>
                    <h3>Sedikit Pembuka</h3>
                    <p>Seorang perantau dari jakarta yang mencari ilmu di its surabaya dengan tekad kuat, walaupun kadang retak sedikit tapi kuat lagi.. berpegang pada quote ini untuk betahan
    
                        "cobalah yang baru.. semua memang pasti susah pada awalnya." —orang inspiratif
                        </p>
                </div>
                <div>
                    <h3>Edukasi</h3>
                        <div>
                            <p>SDN 01 Pasar Minggu, Jakarta Selatan <span class="tahun-ajar">2006-2012</span></p>
                            <p>SMPN 107 Jakarta Selatan <span class="tahun-ajar">2012-2015</span></p>
                            <p>SMAN 38 Jakarta <span class="tahun-ajar">2015-2018</span></p>
                        </div>
                </div>
                <div>
                    <h3>Skills</h3>
                    <p>C++</p>
                    <div class="meter">
                        <span style="width: 70%; background-color: green;"></span>
                    </div>
                    <p>HTML</p>
                    <div class="meter">
                        <span style="width: 10%; background-color: red;"></span>
                    </div>
                    <p>java</p>
                    <div class="meter">
                        <span style="width: 50%; background-color: yellow;"></span>
                    </div>
                    <p>MySQL</p>
                    <div class="meter">
                        <span style="width: 80%; background-color: green;"></span>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>

