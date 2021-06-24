<?php

defined('BASEPATH') or exit('No direct script access allowed');

class Mahasiswa extends CI_Model 
{
    private $_table = "mahasiswa";

    public $id;
    public $nrp;
    public $nama;
    public $alamat;
    public $nohp;
    public $jurusan;

    public function getAll()
    {
        return $this->db->get($this->_table)->result();
    }
    
    public function getById($id)
    {
        return $this->db->get_where($this->_table, ["id" => $id])->row();
    }

    public function save($data)
    {
        var_dump($data);
        return $this->db->insert($this->_table, $data);
    }
    
    public function update($id, $data)
    {
        return $this->db->update($this->_table, $data, array('id' => $id));
    }

    public function delete($id)
    {
        return $this->db->delete($this->_table, array("id" => $id));
    }
}

?>