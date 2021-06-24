<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Welcome extends CI_Controller {

	/**
	 * Index Page for this controller.
	 *
	 * Maps to the following URL
	 * 		http://example.com/index.php/welcome
	 *	- or -
	 * 		http://example.com/index.php/welcome/index
	 *	- or -
	 * Since this controller is set as the default controller in
	 * config/routes.php, it's displayed at http://example.com/
	 *
	 * So any other public methods not prefixed with an underscore will
	 * map to /index.php/welcome/<method_name>
	 * @see https://codeigniter.com/user_guide/general/urls.html
	 */

	public function __construct()
    {
        parent::__construct();
        $this->load->model("mahasiswa");
		$this->load->helper('url');
    }

	public function index()
	{
		$data['mhs'] = $this->mahasiswa->getAll();
		$this->load->view('list_mhs', $data);
	}
	public function cv()
	{
		$this->load->view('welcome_message');
	}	

	public function add()
	{
		if ($this->input->server('REQUEST_METHOD') === 'POST') {
			$data = $this->input->post();
			$this->mahasiswa->save($data);
			redirect(base_url() . '/welcome/index');
		}
		else{
			$this->load->view('insert_mhs');
		}
	}
	
	public function delete($id)
	{
		$this->mahasiswa->delete($id);
		redirect(base_url() . '/welcome/index');
	}

	public function edit($id = null)
	{
		if ($this->input->server('REQUEST_METHOD') === 'POST') {
			$data = $this->input->post();
			$this->mahasiswa->update($id, $data);
			redirect(base_url() . '/welcome/index');
		}
		else{
			$data['mhs'] = $this->mahasiswa->getById($id);
			$this->load->view('edit_mhs', $data);
		}
	}
}
